using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploNorthwind.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public string NickName { get; set; }
        public List<Order> Orders { get; set; }
        public decimal OrdersTotal
        {
            get
            {
                if (Orders == null) return 0;
                return Orders.Sum(o => o.Total);
            }
        }
    }
}
