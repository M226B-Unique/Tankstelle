using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tankstellen_Applikation.Connection.APIs
{
    public class ApiConnection
    {
        public void GetImportantJsonValuesForFuelData()
        {
            string[] json = FuelPrice_API.GetApiValues();
        }
    }
}
