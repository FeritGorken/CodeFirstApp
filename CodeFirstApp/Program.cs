using CodeFirstApp.Context;
using CodeFirstApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var northwind=new NorthwindContext())
            {
                var customer = northwind.Customers.Find("Ferit");
                customer.ContactName = "Ferit gsdg";
                northwind.SaveChanges();
            }
            
            //using (var northwind=new NorthwindContext())
            //{
            //    var customer = northwind.Customers.Find("Ferit");
            //    northwind.Customers.Remove(customer);
            //    northwind.SaveChanges();
            //}




            //using (var northwind=new NorthwindContext())
            //{
            //    Customer customer = northwind.Customers.Find("Ferit");
            //    customer.Orders.Add(
            //        new Order
            //        {
            //            OrderID = 1,
            //            OrderDate = DateTime.Now,
            //            ShipCity = "Ankara",
            //            ShipCountry = "TÜRKİYE"
            //        });
            //    northwind.SaveChanges();
            //}



            //using (var northwind=new NorthwindContext())
            //{
            //    var customer = new Customer
            //    {
            //        CustomerID="Ferit",
            //        City="İstanbul",
            //        CompanyName="Spidya",
            //        ContactName="Ferit Görken",
            //        Country="Türkiye"
            //    };
            //    northwind.Customers.Add(customer);
            //    northwind.SaveChanges();
            //}


            //IDisposable Mod
            //using (var northwind = new NorthwindContext())
            //{
            //    foreach (var customer in northwind.Customers)
            //    {
            //        Console.WriteLine("Customer name {0}", customer.ContactName);
            //    }
            //}
            Console.ReadLine();
        }
    }
}
