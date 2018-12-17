using FuelApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] json = CallApi.GetApiValues();

            foreach (string item in json)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n----------------");

            string json2 = CallApi.GetApiValuesCHFEUR();

            Console.WriteLine(json2);

            Console.ReadKey();
        }
    }
}
