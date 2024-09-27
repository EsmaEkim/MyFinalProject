using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Simuliert, als ob es von Oracle, SQL oder einem anderen Datenbankserver stammt.
            _products = new List<Product> {
            new Product {ProductId=1, CategoryId=1, ProductName="Tastatur",UnitPrice=15,UnitsInStock=15},
            new Product {ProductId=2, CategoryId=2, ProductName="Maus",UnitPrice=500,UnitsInStock=3},
            new Product {ProductId=3, CategoryId=3, ProductName="Mauspad",UnitPrice=1500,UnitsInStock=2},
            new Product {ProductId=4, CategoryId=4, ProductName="Bluetooth-Kopfhörer",UnitPrice=150,UnitsInStock=65},
            new Product {ProductId=1, CategoryId=1, ProductName="Smartwatch",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId); //as a foreach
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            //Finde das Produkt in der Liste mit der angegebenen Produkt-ID
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            
        }
    }
}
