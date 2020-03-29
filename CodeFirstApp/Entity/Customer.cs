using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstApp.Entity
{
    public class Customer
    {
        //ilk orderin null gelme olayını yok etmek için constructor yaptım
        public Customer()
        {
            Orders = new List<Order>();
        }
        public string CustomerID { get; set; }
        public string ContactName { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        //Bir müşterinin birden fazla müşterisi olabilir durumu
        public List<Order> Orders { get; set; }
    }
}
