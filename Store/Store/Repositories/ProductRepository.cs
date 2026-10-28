using Store.Interfaces;
using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product { Id_product = 1, Name = "Laptop", Price = 1200.50m, Category = "Electronics", IsActive = true },
                new Product { Id_product = 2, Name = "Wireless Mouse", Price = 25.99m, Category = "Electronics", IsActive = true },
                new Product { Id_product = 3, Name = "Ergonomic Chair", Price = 150.00m, Category = "Furniture", IsActive = true },
                new Product { Id_product = 4, Name = "Mechanical Keyboard", Price = 85.00m, Category = "Electronics", IsActive = true }
            };
        }

        /// <summary>
        /// Ingresa un nuevo producto en memoria
        /// </summary>
        public void Add(Product product)
        {
            _products.Add(product);
        }

        /// <summary>
        /// Devuelve una copia de los productos usan LINQ
        /// </summary>
        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        /// <summary>
        /// Se utiliza LINQ para buscar el primer productoque coincida con el ID 
        /// sino devuelve null
        /// </summary>
        public Product GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id_product == id);
        }

        /// <summary>
        /// Se utiliza LINQ para filtrar los productos
        /// </summary>
        public List<Product> GetByCategory(string category)
        {
            return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }       
    }
}