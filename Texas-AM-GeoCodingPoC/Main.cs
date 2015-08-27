using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Texas_AM_GeoCodingPoC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

      

        private void btnGo_Click(object sender, EventArgs e)
        {
            string requestUrl = BuildRequestUrl(txtAdd1.Text, txtAddr2.Text, txtCity.Text, txtState.Text, txtZip.Text);
            string result = CallService(requestUrl);


            txtResult.Text = result;
        }

        private string getWsUrl()
        {
            return ConfigurationManager.AppSettings["Texas-AM-Http-WebService-Url"];
        }

        private string getApiKey()
        {
            return ConfigurationManager.AppSettings["Texas-AM-ApiKey"];
        }


        private string BuildRequestUrl(string addr1, string addr2, string city, string st, string z = null)
        {
            string url = "";
            url += getWsUrl() + "apiKey=" + getApiKey();
            url += "&version=4.01";
            url += "&streetAddress=" + addr1 + " " + addr2;
            url += "&city=" + city;
            url += "&state=" + st;
            if(z != null)
                url += "&zip=" + z; //optional
            url += "&format=xml"; //optional

            return url;
        }

        private string CallService(string reqUrl)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(reqUrl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
            HttpResponseMessage response = client.GetAsync(reqUrl).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                //foreach (var d in dataObjects)
                //{
                //    Console.WriteLine("{0}", d.ToString());
                //}
                return dataObjects;
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                return response.ReasonPhrase + " :: " + response.RequestMessage;
            }
        }

    }
}
