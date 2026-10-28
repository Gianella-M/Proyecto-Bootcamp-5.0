using System;
using Store.Models;
using Store.Interfaces;
using Store.Repositories;

IProductRepository repo = new ProductRepository();

Console.WriteLine("Lista completa de productos:");
foreach (var p in repo.GetAll())
{
    Console.WriteLine($"[{p.Id}] {p.Name} - {p.Category} - ${p.Price}");
}
