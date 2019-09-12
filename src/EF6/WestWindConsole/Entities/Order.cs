using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    public class Order
    {

        public int OrderID { get; set; }
        public int SalesRepID { get; set; }
        public string CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime PaymentDueDate { get; set; }
        public double Freight { get; set; }
        public double Shipped { get; set; }
        public string ShipName { get; set; }
        public int ShipAdressID { get; set; }
        public string Comments { get; set; }
    }
}
