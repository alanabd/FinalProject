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
            Console.WriteLine("10 ile 20 arasındaki veri sayısı {0} dır",sayi.ToString());
            foreach (var item in productManager.GetByUnitPrice(11,20))
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}
