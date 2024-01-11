// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.EntityFrameworkCore;
using Seance3.Models;
using System.Linq;

NorthwindContext context = new NorthwindContext();






IQueryable<Customer> cust3 = (from c in context.Customers
                             select c);

foreach (Customer c in cust3)
{
    c.ContactName = c.ContactName.ToUpper();
}

context.SaveChanges();

cust3 = (from c in context.Customers
         select c);

foreach (Customer c in cust3)
{
    Console.WriteLine(c.ContactName);
}