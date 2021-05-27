using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelCL
{
    public class Repository
    {
        public Product GetProductByID(int ID)
        {
            //var Context = new NorthwindEntities();
            //return Products.FirstOrDefault(p => p.ProductID == ID);
            var Context = new NorthwindEntities();
            return Context.Products.FirstOrDefault(p => p.ProductID == ID);
        }
        public List<Product> GetProducts()
        {
            List<Product> Result = null;
            using (var Context = new NorthwindEntities())
            {
                Result = Context.Products.ToList();
            }
            return Result;
        }
        List<Product> Products = new List<Product>
        {
            new Product
            {
                ProductID=1,ProductName="Sal",
                UnitPrice=20,UnitsInStock=20
            },
            new Product
            {
                ProductID=2,ProductName="Aceite",
                UnitPrice=150,UnitsInStock=30
            },
            new Product
            {
                ProductID=3,ProductName="Azucar",
                UnitPrice=15,UnitsInStock=30
            },
            new Product
            {
                ProductID=4,ProductName="Canela",
                UnitPrice=154,UnitsInStock=305
            },

        };
    }
}
