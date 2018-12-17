using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tankstellen_Applikation.Connection.APIs
{
    public static class FuelPrice_API
    {
        static string URL = 
            "https://creativecommons.tankerkoenig.de/json/prices.php?ids=4429a7d9-fb2d-4c29-8cfe-2ca90323f9f8&apikey=2c09d493-55e2-b172-fcfe-2b87b5dfbc5f";

        public static string[] GetApiValues()
        {
            string json = string.Empty;

            using (WebClient webClient = new WebClient())
            { //todo
                //HTTP-Response überprüfen um Fehlermeldung zu bekommen falls API down ist.
                json = webClient.DownloadString(URL);
            }

            string[] jsonData = json.Split(',');

            string[] fuelPrices = new string[3];

            foreach (string jsonObject in jsonData)
            {
                //Json formatierung und auslesen
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
    }
}
