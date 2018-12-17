using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Net;
using System.Web;

namespace FuelApi
{
    public class CallApi
    {
        static string URL = "https://creativecommons.tankerkoenig.de/json/prices.php?ids=4429a7d9-fb2d-4c29-8cfe-2ca90323f9f8&apikey=2c09d493-55e2-b172-fcfe-2b87b5dfbc5f";
        static string URL2 = "https://forex.1forge.com/1.0.3/convert?from=EUR&to=CHF&quantity=1&api_key=XMInXUpUugMZWHzanRjj3gXag2UdDihy";

        public static string[] GetApiValues()
        {
            string json = "";


            using (WebClient webClient = new WebClient())
            { //todo
                //HTTP-Response überprüfen um Fehlermeldung zu bekommen falls API down ist.
                json = webClient.DownloadString(URL);
            }


            string[] jsonData = json.Split(',');

            string[] fuelPrices = new string[3];

            foreach (string jsonObject in jsonData)
            {
                if (jsonObject.Contains("diesel"))
                {
                    fuelPrices[0] = jsonObject.Replace('}', ' ');
                }
                else if (jsonObject.Contains("e5"))
                {
                    fuelPrices[1] = jsonObject;
                }
                else if (jsonObject.Contains("e10"))
                {
                    fuelPrices[2] = jsonObject;
                }
            }

            return fuelPrices;
        }

        public static string GetApiValuesCHFEUR()
        {
            string json = "";

            using (WebClient webClient = new WebClient())
            {
                json = webClient.DownloadString(URL2);
            }

            JavaScriptSerializer

            json = json.Split(',')[0].Replace('{', ' ');

            return json;
        }
    }
}
