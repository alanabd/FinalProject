﻿using System;
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

            var result = productManager.GetAll();
            
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + "\t\t\t\t" + result.Message);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            //CategoryManager category = new CategoryManager(new EfCategoryDal());
            //Console.WriteLine(category.GetById(1).CategoryName);

        }
    }
}
