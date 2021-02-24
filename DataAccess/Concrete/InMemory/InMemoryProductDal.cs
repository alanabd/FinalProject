using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products=new List<Product>
            {
                new Product
                {
                    ProductId = 1,
                    CategoryId = 1,
                    ProductName = "Bardak",
                    UnitsInStock = 15,
                    UnitPrice = 15
                },
                new Product
                {
                    ProductId = 2,
                    CategoryId = 1,
                    ProductName = "Kamera",
                    UnitsInStock = 3,
                    UnitPrice = 500
                },
                new Product
                {
                    ProductId = 3,
                    CategoryId = 2,
                    ProductName = "Telefon",
                    UnitsInStock = 2,
                    UnitPrice = 1500
                },
                new Product
                {
                    ProductId = 4,
                    CategoryId = 2,
                    ProductName = "Klavye",
                    UnitsInStock = 65,
                    UnitPrice = 150
                },
                new Product
                {
                    ProductId = 5,
                    CategoryId = 2,
                    ProductName = "Fare",
                    UnitsInStock = 1,
                    UnitPrice = 85
                }
            };
        }
        public List<Product> GetAll()
        {
            return _products;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
            /*
             * productToTable.FirstName=product.FirstName şeklinde güncelleme yaptı hoca
             */
            productToUpdate = product;
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(s => s.CategoryId == categoryId).ToList();
        }
    }
}
