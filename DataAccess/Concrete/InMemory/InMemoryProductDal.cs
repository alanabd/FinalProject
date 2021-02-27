using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

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
                    ProductID = 1,
                    CategoryID = 1,
                    ProductName = "Bardak",
                    UnitsInStock = 15,
                    UnitPrice = 15
                },
                new Product
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ProductName = "Kamera",
                    UnitsInStock = 3,
                    UnitPrice = 500
                },
                new Product
                {
                    ProductID = 3,
                    CategoryID = 2,
                    ProductName = "Telefon",
                    UnitsInStock = 2,
                    UnitPrice = 1500
                },
                new Product
                {
                    ProductID = 4,
                    CategoryID = 2,
                    ProductName = "Klavye",
                    UnitsInStock = 65,
                    UnitPrice = 150
                },
                new Product
                {
                    ProductID = 5,
                    CategoryID = 2,
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
            Product productToDelete = _products.SingleOrDefault(x => x.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(x => x.ProductID == product.ProductID);
            /*
             * productToTable.FirstName=product.FirstName şeklinde güncelleme yaptı hoca
             */
            productToUpdate = product;
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(s => s.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> getProductDetailDto()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
