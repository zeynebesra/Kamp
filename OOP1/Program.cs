﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.şekil
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //2.şekil
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //instance create -örnek oluşturma
            //case sensitive - duyarlı
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



        }
    }
}
