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
    public static class EUR_CHF
    {
        static string URL = "https://forex.1forge.com/1.0.3/convert?from=EUR&to=CHF&quantity=1&api_key=XMInXUpUugMZWHzanRjj3gXag2UdDihy";

        public static string GetApiValues()
        {
            string json = "";

            using (WebClient webClient = new WebClient())
            {
                json = webClient.DownloadString(URL);
            }

            json = json.Split(',')[0].Replace('{', ' ');        //Filtern von json
            
            return json;
        }
    }
}
