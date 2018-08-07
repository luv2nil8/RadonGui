using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RadonGui
{
    public class ISNWebCall : HttpClient

    {

        public string company { get; set; }
        public string key  { get; set; }
        public string secretKey { get; set; }
        public Me me = new Me();




        public ISNWebCall()
        {
            company = Properties.Settings.Default.company;
            key = Properties.Settings.Default.key;
            secretKey = Properties.Settings.Default.secretkey;



            Console.WriteLine(string.Format("https://goisn.net/{0}/rest", company));
            BaseAddress = new Uri(string.Format("https://goisn.net/{2}/rest/", key, secretKey, company));
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<string> getISNData(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await GetAsync(endpoint);
                //Console.WriteLine("HttpStatusCode: " + response.StatusCode);
                var contents = await response.Content.ReadAsStringAsync();
                //Console.WriteLine("Contents: "+contents);
                return contents;
            }
            catch(HttpRequestException e)
            {
                return e.Message;
                
            }
        }
        public async Task<Order> GetOrderByOID(string OID)
        {
            //Console.WriteLine(await getISNData("orders/search?reportnumber=" + OID));
            //Console.WriteLine(orders.ToString());
            Response response = new Response();
            var _order = JObject.Parse( await getISNData("orders/search?reportnumber=" + OID));
            response = _order.ToObject<Response>();
            List<Order> orderList = new List<Order>();
            foreach (var order in response.orders){

                JObject x = JsonConvert.DeserializeObject<JObject>(await getISNData("order/" + order.id));
                var node = x["order"].ToObject<Order>();
                Console.WriteLine("Parsed Order: "+x);
                Console.WriteLine(order.stateabbreviation);
                if (!(node.canceled.Equals("yes"))) orderList.Add(node);               
            }
            response.orders = orderList;
            

            return response.orders[0];
        }


        public bool valid8LoginInfo()
        {
            DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(
                System.Text.ASCIIEncoding.ASCII.GetBytes(
                    string.Format("{0}:{1}", key, secretKey))));

            JObject response = JsonConvert.DeserializeObject<JObject>
                (
                    (this.GetAsync("me/").Result)
                    .Content.ReadAsStringAsync().Result
                );

            //Console.WriteLine("Validation: "+response);

            if (response.ToObject<Response>().status=="ok")
            {
                me = response["me"].ToObject<Me>();
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}