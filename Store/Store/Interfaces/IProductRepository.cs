using Store.Models;
using System.Collections.Generic;


namespace Store.Interfaces
{
    /// <summary>
    /// Define las operaciones de persistencia necesarias
    /// para trabajar con productos dentro de la aplicación.
    /// </summary>
    public interface IProductRepository
    {
        void Add(Product product);
        List<Product> GetAll();
        Product GetById(int id);
        List<Product> GetByCategory(string category);
    }
}