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
            List<Product> products = new List<Product>();

            ProductsServiceClient proxy = new ProductsServiceClient();
            Console.WriteLine("Appel de la méthode distante 'GetData' ...");
            Console.WriteLine(proxy.GetData(99));
            Console.WriteLine("-----------------------");
            Console.WriteLine("Appel de la méthode distante 'GetProducts'... ");
            products = proxy.GetProducts("R");
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductID + " : " + item.Name + " : " + item.Color + " : " + item.ListPrice);
            }
            Console.ReadLine();
        }
    }
}
