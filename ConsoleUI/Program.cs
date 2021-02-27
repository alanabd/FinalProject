using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            int sayi = productManager.GetByUnitPrice(15, 20).Count;
            Console.WriteLine("10 ile 20 arasındaki veri sayısı {0} dır", sayi.ToString());
            foreach (var item in productManager.getProductDetails())
            {
                Console.WriteLine(item.ProductName+"\t\t\t\t"+item.CategoryName);
            }
            //CategoryManager category = new CategoryManager(new EfCategoryDal());
            //Console.WriteLine(category.GetById(1).CategoryName);

        }
    }
}
