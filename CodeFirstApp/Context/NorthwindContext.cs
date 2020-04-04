using CodeFirstApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Context
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public NorthwindContext():base("NorthwindDB")
        {

        }
        
       
    }
}
