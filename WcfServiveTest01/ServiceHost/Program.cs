using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceLibrary1;

namespace ServiceHost
{
    /// <summary>
    /// Class to host Service
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(ProductsService));
            host.Open();
            Console.WriteLine("Service STARTED...");
            Console.ReadLine();
            host.Close();
        }
    }
}
