using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public DateTime PaymentDate { get; set; }
        public double Amount { get; set; }
        public int PaymentTypeID { get; set; }
        public int OrderID { get; set; }
        public int TransactionID { get; set; }
        public DateTime ClearedDate { get; set; }

    }
}
