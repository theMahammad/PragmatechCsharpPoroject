using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_ShoppingManagement_
{
    class Order
    {
        
        public string category { get; set; }
        public string product { get; set; }
        public string delivery_type { get; set; }
        public double weight { get; set; }
        public  decimal price { get; set; }
        public DateTime date { get; set; }
    }
}
