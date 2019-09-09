using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.Entities;

namespace WestWindConsole.DAL
{
    public class WestWindContext : DbContext
    {
        //My database context class is a :virtual representation"
        //of the database, with each DbSet<T> property referencing
        // 
        public WestWindContext() : base("name=WWdb")
        {
            // TODO: Demonstrate null database initializer
            // tells entity framework that it should not create any tables
            // in the database on my behalf.
            // (null == no initializer)
            // This is an example of disabling database
            Database.SetInitializer<WestWindContext>(null);
            //An alternative to this woild be to disable database 
            // initialization in the .config file.
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }

        // TODO: Practice - Add entities and DbSet<> properties for the remaining tables
    }
}
