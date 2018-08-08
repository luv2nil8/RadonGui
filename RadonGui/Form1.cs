using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadonGui

{
    public partial class Form1 : Form
    {
        ISNWebCall isnWebCall = new ISNWebCall();

        public Form1()
        {
            InitializeComponent();

            if (isnWebCall.valid8LoginInfo())
            {
                inspectorNameTextBox.Text = isnWebCall.me.firstname;
                companyTextBox.Text = isnWebCall.company;
                keyTextBox.Text = isnWebCall.key;
                secretkeyTextBox.Text = isnWebCall.secretKey;
                


                DataEntryTabs.SelectedIndex = 0;

            }
            else
            {
                validationFailed();
            }
            //Console.WriteLine(isnWebCall.getISNData("orders/").Result);


        }


        private void submitkeys_Click(object sender, EventArgs e)
        {
            keyTextBox.Text.Trim();
            secretkeyTextBox.Text.Trim();


            isnWebCall.company = companyTextBox.Text;
            Console.WriteLine("Company: "+ isnWebCall.company);

            isnWebCall.key = keyTextBox.Text;
            Console.WriteLine("Key: " + isnWebCall.key);

            isnWebCall.secretKey = secretkeyTextBox.Text;
            Console.WriteLine("Secret Key: " + isnWebCall.secretKey);

            if (isnWebCall.valid8LoginInfo())
            {
                Properties.Settings.Default.company = companyTextBox.Text;
                Console.WriteLine(Properties.Settings.Default.company);

                Properties.Settings.Default.key = keyTextBox.Text;
                Console.WriteLine(Properties.Settings.Default.key);

                Properties.Settings.Default.secretkey = secretkeyTextBox.Text;
                Console.WriteLine(Properties.Settings.Default.secretkey);
         
                Properties.Settings.Default.Save();

                DataEntryTabs.SelectedIndex = 0;

                ErrorLabel.Text = "";

                Console.WriteLine("FirstName: " + isnWebCall.me.firstname);
                inspectorNameTextBox.Text = isnWebCall.me.firstname;

            }
            else
            {
                validationFailed();
            }
        }
        private void validationFailed()
        {
            DataEntryTabs.SelectedIndex = 2;
            ErrorLabel.Text = "Login failed, did you reset, or enter the wrong keys?";
            
        }

        /*  OBSOLETE
        private void HideOtherPanels()
        {
            var children = this.Controls.OfType<Control>();

            foreach (var child in children)
            {
                child.Visible = false;
            }
        }
        */

        private void SubmitDataButton_Click(object sender, EventArgs e)
        {
            String html = System.IO.File.ReadAllText(@"C:\Users\hunte\Documents\templateAlpha.txt");

            List<string> radonData = new List<string>();
            foreach (Match match in Regex.Matches(radonDataTextBox.Text, "[0-9]+\\.[0-9]+"))
            {
                Console.WriteLine(match.ToString());
                radonData.Add(match.ToString());
            }
            Console.WriteLine(radonData.Count());
            if (radonData.Count() < 50)
            {
                MessageBox.Show("Only " + (radonData.Count - 2) + " hours have been recorded.");
                return;
            }
            radonData.RemoveRange(48, radonData.Count()-48);
            Console.WriteLine(radonData.Count());

            html = Regex.Replace(html, "%startDate%", dateTimePicker.Value.ToShortDateString());

            html = Regex.Replace(html, "%startTime%", string.Format("{0}:{1} {2}", timeSetHourComboBox.Text, timeSetMinuteComboBox.Text, AMPMButton.Text));

            html = Regex.Replace(html, "%endDate%", DateTime.Now.ToShortTimeString());

            html = Regex.Replace(html, "%endTime%", DateTime.Now.ToShortDateString());

            string location = addressTextBox.Text;
            location = Regex.Replace(location, Environment.NewLine, "</br>");

            html = Regex.Replace(html, "%location%", location);

            html = Regex.Replace(html, "%serial%", monitorNumber.Value.ToString());

            html = Regex.Replace(html, "%inspector%", inspectorNameTextBox.Text);

            double average = 0;
            double epaAverage = 0;
            for (int dataToAverage = 0; dataToAverage < 48; dataToAverage++)
            {
                if (dataToAverage > 3) epaAverage += System.Convert.ToDouble(radonData[dataToAverage]);
                average += System.Convert.ToDouble(radonData[dataToAverage]);
            }
            average = average / radonData.Count();
            epaAverage = epaAverage / (radonData.Count() - 4);
            html  = Regex.Replace(html, "%average%", String.Format("{0:F2}", average));
            html  = Regex.Replace(html, "%EPAAverage%", String.Format("{0:F2}", epaAverage));
         

            string rawData ="";
            string rawDataArray ="";
            int itemLimiter = 1;
            foreach (string item in radonData)
            {
                if (itemLimiter >= 49) break;
                rawData += "<div class=\"col\">" + item + "</div>";
                if (itemLimiter % 6 == 0) rawData +="<div class=\"w-100\"></div>";
                rawDataArray += item + ",";
                itemLimiter++;
            }
            rawDataArray.Trim(',');//get rid of the last comma
            html = Regex.Replace(html, "%rawData%", rawData);
            html = Regex.Replace(html, "%rawDataArray%", rawDataArray);
            Console.WriteLine(html);
            //TODO: Print to PDF File with puppeteer

        }

        private void VisitISNPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitISNPage.LinkVisited = true;

            System.Diagnostics.Process.Start("https://goisn.net/nookandkrannyhomeinspections/access-keys");
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            String text = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Environment.OSVersion.Version.Major >= 6)
            {
                path = Directory.GetParent(path).ToString();
            }

            openFileDialog1.InitialDirectory = path;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((text = System.IO.File.ReadAllText(openFileDialog1.FileName)) != null)
                    {
                        Console.WriteLine(openFileDialog1.FileName);
                            radonDataTextBox.Text= text;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void VisitISNPage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://goisn.net/nookandkrannyhomeinspections/access-keys");

        }

        private async void getISNDataFromOIDButton_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                Order order = await isnWebCall.GetOrderByOID(getISNDataFromOIDTextbox.Text);
                ClientInfoErrorLabel.Text = "";
                dateTimePicker.Value = order.datetime;
                addressTextBox.Text = string.Format("{0}{3}{1}, {2}", order.address1, order.city, order.stateabbreviation, Environment.NewLine);
                DateTime timeSet = order.datetime;
                timeSetMinuteComboBox.Text = (timeSet.Minute - (timeSet.Minute % 5)).ToString("D2");
                timeSetHourComboBox.Text = timeSet.Hour.ToString();
                AMPMButton.Text = timeSet.ToString("tt", CultureInfo.InvariantCulture); ;
            }
            catch (Exception)
            {
                ClientInfoErrorLabel.Text = "Not Found on your ISN";
                Console.WriteLine("Not Found");
            }



        }

        private void AMPMButton_Click(object sender, EventArgs e)
        {
            AMPMButton.Text = (AMPMButton.Text == "AM") ? "PM" : "AM";
        }
    }
}
