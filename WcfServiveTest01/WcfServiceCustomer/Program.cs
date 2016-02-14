using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfServiceCustomer.ServiceRefProducts;

namespace WcfServiceCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductsServiceClient proxy = new ProductsServiceClient();
            Console.WriteLine("Appel de la méthode distante...");
            Console.WriteLine(proxy.GetData(99));
            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
        }
    }
}
