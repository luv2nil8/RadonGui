namespace RadonGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubmitDataButton = new System.Windows.Forms.Button();
            this.DataEntryTabs = new System.Windows.Forms.TabControl();
            this.RadonDataTab = new System.Windows.Forms.TabPage();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.radonDataTextBox = new System.Windows.Forms.TextBox();
            this.ClientDataTab = new System.Windows.Forms.TabPage();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateSetLabel = new System.Windows.Forms.Label();
            this.ClientInfoErrorLabel = new System.Windows.Forms.Label();
            this.monitorNumberLabel = new System.Windows.Forms.Label();
            this.monitorNumber = new System.Windows.Forms.NumericUpDown();
            this.getISNDataFromOIDButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getISNDataFromOIDTextbox = new System.Windows.Forms.TextBox();
            this.timeSetLabel = new System.Windows.Forms.Label();
            this.colonLabel = new System.Windows.Forms.Label();
            this.AMPMButton = new System.Windows.Forms.Button();
            this.timeSetMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.timeSetHourComboBox = new System.Windows.Forms.ComboBox();
            this.inspectorNameTextBox = new System.Windows.Forms.TextBox();
            this.inspectorNameTextBoxLabel = new System.Windows.Forms.Label();
            this.addressTextBoxLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.clientInfoLabel = new System.Windows.Forms.Label();
            this.ISNDataTab = new System.Windows.Forms.TabPage();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.VisitISNPage = new System.Windows.Forms.LinkLabel();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.secretkeyLabel = new System.Windows.Forms.Label();
            this.secretkeyTextBox = new System.Windows.Forms.TextBox();
            this.submitkeys = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.DataEntryTabs.SuspendLayout();
            this.RadonDataTab.SuspendLayout();
            this.ClientDataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorNumber)).BeginInit();
            this.ISNDataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SubmitDataButton);
            this.panel1.Controls.Add(this.DataEntryTabs);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MinimumSize = new System.Drawing.Size(380, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 314);
            this.panel1.TabIndex = 20;
            // 
            // SubmitDataButton
            // 
            this.SubmitDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitDataButton.Location = new System.Drawing.Point(275, 0);
            this.SubmitDataButton.Name = "SubmitDataButton";
            this.SubmitDataButton.Size = new System.Drawing.Size(103, 22);
            this.SubmitDataButton.TabIndex = 21;
            this.SubmitDataButton.Text = "Make PDF";
            this.SubmitDataButton.UseVisualStyleBackColor = true;
            this.SubmitDataButton.Click += new System.EventHandler(this.SubmitDataButton_Click);
            // 
            // DataEntryTabs
            // 
            this.DataEntryTabs.Controls.Add(this.RadonDataTab);
            this.DataEntryTabs.Controls.Add(this.ClientDataTab);
            this.DataEntryTabs.Controls.Add(this.ISNDataTab);
            this.DataEntryTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataEntryTabs.Location = new System.Drawing.Point(0, 0);
            this.DataEntryTabs.Margin = new System.Windows.Forms.Padding(0);
            this.DataEntryTabs.Name = "DataEntryTabs";
            this.DataEntryTabs.Padding = new System.Drawing.Point(0, 0);
            this.DataEntryTabs.SelectedIndex = 0;
            this.DataEntryTabs.Size = new System.Drawing.Size(380, 314);
            this.DataEntryTabs.TabIndex = 20;
            // 
            // RadonDataTab
            // 
            this.RadonDataTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RadonDataTab.Controls.Add(this.ConnectionStatus);
            this.RadonDataTab.Controls.Add(this.OpenFileButton);
            this.RadonDataTab.Controls.Add(this.radonDataTextBox);
            this.RadonDataTab.Location = new System.Drawing.Point(4, 22);
            this.RadonDataTab.Margin = new System.Windows.Forms.Padding(0);
            this.RadonDataTab.Name = "RadonDataTab";
            this.RadonDataTab.Size = new System.Drawing.Size(372, 288);
            this.RadonDataTab.TabIndex = 0;
            this.RadonDataTab.Text = "Radon Data";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Location = new System.Drawing.Point(3, 269);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(107, 15);
            this.ConnectionStatus.TabIndex = 8;
            this.ConnectionStatus.Text = "Connect A Monitor";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenFileButton.Location = new System.Drawing.Point(271, 39);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(101, 23);
            this.OpenFileButton.TabIndex = 6;
            this.OpenFileButton.Text = "Open .txt File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // radonDataTextBox
            // 
            this.radonDataTextBox.AcceptsReturn = true;
            this.radonDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radonDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radonDataTextBox.Location = new System.Drawing.Point(0, 0);
            this.radonDataTextBox.Multiline = true;
            this.radonDataTextBox.Name = "radonDataTextBox";
            this.radonDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.radonDataTextBox.Size = new System.Drawing.Size(271, 265);
            this.radonDataTextBox.TabIndex = 5;
            // 
            // ClientDataTab
            // 
            this.ClientDataTab.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientDataTab.Controls.Add(this.dateTimePicker);
            this.ClientDataTab.Controls.Add(this.dateSetLabel);
            this.ClientDataTab.Controls.Add(this.ClientInfoErrorLabel);
            this.ClientDataTab.Controls.Add(this.monitorNumberLabel);
            this.ClientDataTab.Controls.Add(this.monitorNumber);
            this.ClientDataTab.Controls.Add(this.getISNDataFromOIDButton);
            this.ClientDataTab.Controls.Add(this.label1);
            this.ClientDataTab.Controls.Add(this.getISNDataFromOIDTextbox);
            this.ClientDataTab.Controls.Add(this.timeSetLabel);
            this.ClientDataTab.Controls.Add(this.colonLabel);
            this.ClientDataTab.Controls.Add(this.AMPMButton);
            this.ClientDataTab.Controls.Add(this.timeSetMinuteComboBox);
            this.ClientDataTab.Controls.Add(this.timeSetHourComboBox);
            this.ClientDataTab.Controls.Add(this.inspectorNameTextBox);
            this.ClientDataTab.Controls.Add(this.inspectorNameTextBoxLabel);
            this.ClientDataTab.Controls.Add(this.addressTextBoxLabel);
            this.ClientDataTab.Controls.Add(this.addressTextBox);
            this.ClientDataTab.Controls.Add(this.clientInfoLabel);
            this.ClientDataTab.Location = new System.Drawing.Point(4, 22);
            this.ClientDataTab.Name = "ClientDataTab";
            this.ClientDataTab.Size = new System.Drawing.Size(372, 288);
            this.ClientDataTab.TabIndex = 1;
            this.ClientDataTab.Text = "Client Info";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "ddd, MMMd, yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(205, 198);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(146, 20);
            this.dateTimePicker.TabIndex = 28;
            this.dateTimePicker.Value = new System.DateTime(2018, 8, 8, 13, 16, 55, 892);
            // 
            // dateSetLabel
            // 
            this.dateSetLabel.AutoSize = true;
            this.dateSetLabel.Location = new System.Drawing.Point(205, 180);
            this.dateSetLabel.Name = "dateSetLabel";
            this.dateSetLabel.Size = new System.Drawing.Size(54, 15);
            this.dateSetLabel.TabIndex = 27;
            this.dateSetLabel.Text = "Date Set";
            // 
            // ClientInfoErrorLabel
            // 
            this.ClientInfoErrorLabel.AutoSize = true;
            this.ClientInfoErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ClientInfoErrorLabel.Location = new System.Drawing.Point(61, 87);
            this.ClientInfoErrorLabel.Name = "ClientInfoErrorLabel";
            this.ClientInfoErrorLabel.Size = new System.Drawing.Size(0, 15);
            this.ClientInfoErrorLabel.TabIndex = 26;
            // 
            // monitorNumberLabel
            // 
            this.monitorNumberLabel.AutoSize = true;
            this.monitorNumberLabel.Location = new System.Drawing.Point(240, 49);
            this.monitorNumberLabel.Name = "monitorNumberLabel";
            this.monitorNumberLabel.Size = new System.Drawing.Size(59, 15);
            this.monitorNumberLabel.TabIndex = 25;
            this.monitorNumberLabel.Text = "Monitor #";
            // 
            // monitorNumber
            // 
            this.monitorNumber.Location = new System.Drawing.Point(245, 68);
            this.monitorNumber.Name = "monitorNumber";
            this.monitorNumber.Size = new System.Drawing.Size(46, 20);
            this.monitorNumber.TabIndex = 24;
            // 
            // getISNDataFromOIDButton
            // 
            this.getISNDataFromOIDButton.Location = new System.Drawing.Point(162, 66);
            this.getISNDataFromOIDButton.Name = "getISNDataFromOIDButton";
            this.getISNDataFromOIDButton.Size = new System.Drawing.Size(65, 23);
            this.getISNDataFromOIDButton.TabIndex = 21;
            this.getISNDataFromOIDButton.Text = "Get Data";
            this.getISNDataFromOIDButton.UseVisualStyleBackColor = true;
            this.getISNDataFromOIDButton.Click += new System.EventHandler(this.getISNDataFromOIDButton_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "HomeGuage Report ID";
            // 
            // getISNDataFromOIDTextbox
            // 
            this.getISNDataFromOIDTextbox.Location = new System.Drawing.Point(64, 67);
            this.getISNDataFromOIDTextbox.Name = "getISNDataFromOIDTextbox";
            this.getISNDataFromOIDTextbox.Size = new System.Drawing.Size(92, 20);
            this.getISNDataFromOIDTextbox.TabIndex = 19;
            // 
            // timeSetLabel
            // 
            this.timeSetLabel.AutoSize = true;
            this.timeSetLabel.Location = new System.Drawing.Point(202, 117);
            this.timeSetLabel.Name = "timeSetLabel";
            this.timeSetLabel.Size = new System.Drawing.Size(56, 15);
            this.timeSetLabel.TabIndex = 9;
            this.timeSetLabel.Text = "Time Set";
            // 
            // colonLabel
            // 
            this.colonLabel.AutoSize = true;
            this.colonLabel.Enabled = false;
            this.colonLabel.Location = new System.Drawing.Point(248, 138);
            this.colonLabel.Name = "colonLabel";
            this.colonLabel.Size = new System.Drawing.Size(10, 15);
            this.colonLabel.TabIndex = 8;
            this.colonLabel.Text = ":";
            // 
            // AMPMButton
            // 
            this.AMPMButton.Location = new System.Drawing.Point(312, 135);
            this.AMPMButton.Name = "AMPMButton";
            this.AMPMButton.Size = new System.Drawing.Size(39, 23);
            this.AMPMButton.TabIndex = 7;
            this.AMPMButton.Text = "PM";
            this.AMPMButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AMPMButton.UseVisualStyleBackColor = true;
            this.AMPMButton.Click += new System.EventHandler(this.AMPMButton_Click);
            // 
            // timeSetMinuteComboBox
            // 
            this.timeSetMinuteComboBox.FormattingEnabled = true;
            this.timeSetMinuteComboBox.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.timeSetMinuteComboBox.Location = new System.Drawing.Point(260, 135);
            this.timeSetMinuteComboBox.Name = "timeSetMinuteComboBox";
            this.timeSetMinuteComboBox.Size = new System.Drawing.Size(38, 21);
            this.timeSetMinuteComboBox.TabIndex = 6;
            // 
            // timeSetHourComboBox
            // 
            this.timeSetHourComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.timeSetHourComboBox.FormattingEnabled = true;
            this.timeSetHourComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.timeSetHourComboBox.Location = new System.Drawing.Point(205, 135);
            this.timeSetHourComboBox.MaxDropDownItems = 12;
            this.timeSetHourComboBox.Name = "timeSetHourComboBox";
            this.timeSetHourComboBox.Size = new System.Drawing.Size(38, 21);
            this.timeSetHourComboBox.TabIndex = 5;
            // 
            // inspectorNameTextBox
            // 
            this.inspectorNameTextBox.Location = new System.Drawing.Point(20, 199);
            this.inspectorNameTextBox.Name = "inspectorNameTextBox";
            this.inspectorNameTextBox.Size = new System.Drawing.Size(163, 20);
            this.inspectorNameTextBox.TabIndex = 4;
            // 
            // inspectorNameTextBoxLabel
            // 
            this.inspectorNameTextBoxLabel.AutoSize = true;
            this.inspectorNameTextBoxLabel.Location = new System.Drawing.Point(20, 181);
            this.inspectorNameTextBoxLabel.Name = "inspectorNameTextBoxLabel";
            this.inspectorNameTextBoxLabel.Size = new System.Drawing.Size(94, 15);
            this.inspectorNameTextBoxLabel.TabIndex = 3;
            this.inspectorNameTextBoxLabel.Text = "Inspector Name";
            // 
            // addressTextBoxLabel
            // 
            this.addressTextBoxLabel.AutoSize = true;
            this.addressTextBoxLabel.Location = new System.Drawing.Point(20, 117);
            this.addressTextBoxLabel.Name = "addressTextBoxLabel";
            this.addressTextBoxLabel.Size = new System.Drawing.Size(51, 15);
            this.addressTextBoxLabel.TabIndex = 2;
            this.addressTextBoxLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.AcceptsReturn = true;
            this.addressTextBox.Location = new System.Drawing.Point(20, 135);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(163, 33);
            this.addressTextBox.TabIndex = 1;
            // 
            // clientInfoLabel
            // 
            this.clientInfoLabel.AutoSize = true;
            this.clientInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientInfoLabel.Location = new System.Drawing.Point(99, 12);
            this.clientInfoLabel.Name = "clientInfoLabel";
            this.clientInfoLabel.Size = new System.Drawing.Size(168, 26);
            this.clientInfoLabel.TabIndex = 0;
            this.clientInfoLabel.Text = "Enter Client Info";
            // 
            // ISNDataTab
            // 
            this.ISNDataTab.Controls.Add(this.ErrorLabel);
            this.ISNDataTab.Controls.Add(this.companyLabel);
            this.ISNDataTab.Controls.Add(this.companyTextBox);
            this.ISNDataTab.Controls.Add(this.VisitISNPage);
            this.ISNDataTab.Controls.Add(this.keyTextBox);
            this.ISNDataTab.Controls.Add(this.keyLabel);
            this.ISNDataTab.Controls.Add(this.secretkeyLabel);
            this.ISNDataTab.Controls.Add(this.secretkeyTextBox);
            this.ISNDataTab.Controls.Add(this.submitkeys);
            this.ISNDataTab.Controls.Add(this.instructionsLabel);
            this.ISNDataTab.Location = new System.Drawing.Point(4, 22);
            this.ISNDataTab.Name = "ISNDataTab";
            this.ISNDataTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ISNDataTab.Size = new System.Drawing.Size(372, 288);
            this.ISNDataTab.TabIndex = 2;
            this.ISNDataTab.Text = "ISN Logins";
            this.ISNDataTab.UseVisualStyleBackColor = true;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(16, 218);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(331, 23);
            this.ErrorLabel.TabIndex = 28;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(17, 66);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(82, 15);
            this.companyLabel.TabIndex = 27;
            this.companyLabel.Text = "Company Key";
            // 
            // companyTextBox
            // 
            this.companyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyTextBox.Location = new System.Drawing.Point(19, 87);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(330, 20);
            this.companyTextBox.TabIndex = 26;
            // 
            // VisitISNPage
            // 
            this.VisitISNPage.ActiveLinkColor = System.Drawing.Color.LightSeaGreen;
            this.VisitISNPage.AutoSize = true;
            this.VisitISNPage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.VisitISNPage.LinkColor = System.Drawing.Color.MediumBlue;
            this.VisitISNPage.Location = new System.Drawing.Point(17, 260);
            this.VisitISNPage.Name = "VisitISNPage";
            this.VisitISNPage.Size = new System.Drawing.Size(198, 15);
            this.VisitISNPage.TabIndex = 25;
            this.VisitISNPage.TabStop = true;
            this.VisitISNPage.Text = "CLICK HERE to open your ISN keys";
            this.VisitISNPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VisitISNPage_LinkClicked_1);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.keyTextBox.Location = new System.Drawing.Point(19, 142);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(329, 20);
            this.keyTextBox.TabIndex = 20;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(17, 124);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(68, 15);
            this.keyLabel.TabIndex = 22;
            this.keyLabel.Text = "Access Key";
            // 
            // secretkeyLabel
            // 
            this.secretkeyLabel.AutoSize = true;
            this.secretkeyLabel.Location = new System.Drawing.Point(17, 177);
            this.secretkeyLabel.Name = "secretkeyLabel";
            this.secretkeyLabel.Size = new System.Drawing.Size(106, 15);
            this.secretkeyLabel.TabIndex = 23;
            this.secretkeyLabel.Text = "Secret Access Key";
            // 
            // secretkeyTextBox
            // 
            this.secretkeyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.secretkeyTextBox.Location = new System.Drawing.Point(19, 195);
            this.secretkeyTextBox.Name = "secretkeyTextBox";
            this.secretkeyTextBox.Size = new System.Drawing.Size(329, 20);
            this.secretkeyTextBox.TabIndex = 21;
            this.secretkeyTextBox.UseSystemPasswordChar = true;
            // 
            // submitkeys
            // 
            this.submitkeys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitkeys.Location = new System.Drawing.Point(261, 255);
            this.submitkeys.Name = "submitkeys";
            this.submitkeys.Size = new System.Drawing.Size(88, 23);
            this.submitkeys.TabIndex = 24;
            this.submitkeys.Text = "Submit";
            this.submitkeys.UseVisualStyleBackColor = true;
            this.submitkeys.Click += new System.EventHandler(this.submitkeys_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(15, 18);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(272, 26);
            this.instructionsLabel.TabIndex = 19;
            this.instructionsLabel.Text = "Enter your ISN keys Below";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(539, 426);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Radon Report Maker";
            this.panel1.ResumeLayout(false);
            this.DataEntryTabs.ResumeLayout(false);
            this.RadonDataTab.ResumeLayout(false);
            this.RadonDataTab.PerformLayout();
            this.ClientDataTab.ResumeLayout(false);
            this.ClientDataTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorNumber)).EndInit();
            this.ISNDataTab.ResumeLayout(false);
            this.ISNDataTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SubmitDataButton;
        private System.Windows.Forms.TabControl DataEntryTabs;
        private System.Windows.Forms.TabPage RadonDataTab;
        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.TextBox radonDataTextBox;
        private System.Windows.Forms.TabPage ClientDataTab;
        private System.Windows.Forms.TabPage ISNDataTab;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.LinkLabel VisitISNPage;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label secretkeyLabel;
        private System.Windows.Forms.TextBox secretkeyTextBox;
        private System.Windows.Forms.Button submitkeys;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label clientInfoLabel;
        private System.Windows.Forms.Label colonLabel;
        private System.Windows.Forms.Button AMPMButton;
        private System.Windows.Forms.ComboBox timeSetMinuteComboBox;
        private System.Windows.Forms.ComboBox timeSetHourComboBox;
        private System.Windows.Forms.TextBox inspectorNameTextBox;
        private System.Windows.Forms.Label inspectorNameTextBoxLabel;
        private System.Windows.Forms.Label addressTextBoxLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label timeSetLabel;
        private System.Windows.Forms.Label monitorNumberLabel;
        private System.Windows.Forms.NumericUpDown monitorNumber;
        private System.Windows.Forms.Button getISNDataFromOIDButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox getISNDataFromOIDTextbox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label dateSetLabel;
        private System.Windows.Forms.Label ClientInfoErrorLabel;
    }
}

