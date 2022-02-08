using System;
using System.Data;
using System.IO;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace BestBuyBestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            //Create new Department and List all Departments
            //var repo = new DapperDepartmentRepository(conn);

            //Console.WriteLine("What is the name of your new department?:");

            //var newDepartment = Console.ReadLine();

            //repo.InsertDepartment(newDepartment);

            //var departments = repo.GetAllDepartments();

            //foreach (var dept in departments)
            //{
            //    Console.WriteLine(dept.Name);
            //}

            //Create new Product and List all Products
            //Console.WriteLine("What is the name of the new product?:");

            //var prodName = Console.ReadLine();

            //Console.WriteLine("What is the price of said product?:");

            //var prodPrice = double.Parse(Console.ReadLine());

            //Console.WriteLine("What is the Category ID?");

            //var prodCat = int.Parse(Console.ReadLine());

            //var productRepo = new DapperProductRepository(conn);

            //productRepo.CreateProduct(prodName, prodPrice, prodCat);

            //var prodList = productRepo.GetAllProducts();

            //foreach (var prod in prodList)
            //{
            //    Console.WriteLine(prod.ProductID + " - " + prod.Name);
            //}

            //Update an existing Product
            Console.WriteLine("What is the ProductID of the product you'd like to update?:");

            var prodID = int.Parse(Console.ReadLine());

            Console.WriteLine("What would you like to update the name to?:");

            var prodUpdName = Console.ReadLine();

            Console.WriteLine("What would you like to update the Price to?:");

            var prodUpdPrice = double.Parse(Console.ReadLine());

            var productRepo2 = new DapperProductRepository(conn);

            productRepo2.UpdateProduct(prodUpdName, prodUpdPrice, prodID);

            //Delete an existing Product
            //Console.WriteLine("What is the product ID of the Product you'd like to delete?:");

            //var prodDelID = int.Parse(Console.ReadLine());

            //var prodRepo3 = new DapperProductRepository(conn);

            //prodRepo3.DeleteProduct(prodDelID);
        }
    }
}
