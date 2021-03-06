﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ProductsService : IProductsService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Product> GetProducts(string productLine)
        {
            AdventureWorks2014Entities db = new AdventureWorks2014Entities();
            return db.Products.Where(p => p.ProductLine == productLine).ToList();
        }
    }
}
