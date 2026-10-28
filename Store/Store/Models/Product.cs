using System;

/// <summary>
/// Representa un modelo de producto en el sistema.
/// </summary>
namespace Store.Models
{
    public class Product
    {
        internal readonly object Id;

        public int Id_product { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public string? Category { get; set; }
        public bool IsActive { get; set; }
    }
}