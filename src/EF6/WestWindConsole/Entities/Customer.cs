using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
     public class Customer
    {
        public int CustomersID { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string ContactEmail { get; set; }

        public string AddressID { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }
    }
}
