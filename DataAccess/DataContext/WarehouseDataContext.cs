using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.DataContext
{
    public class WarehouseDataContext : DbContext
    {
        public DbSet<WarehouseItem> WarehouseItems { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var connectionString = $@"Data Source=.;Initial Catalog=StoreWarehouseDB;Integrated Security=True; TrustServerCertificate=True";
        //    optionsBuilder.UseSqlServer(connectionString);
        //}
        public WarehouseDataContext(DbContextOptions<WarehouseDataContext> options) : base(options)
        {

        }
        public WarehouseDataContext()
        {

        }
        //static WarehouseDataContext()
        //{
        //    Database.SetInitializer<WarehouseDataContext>(new StoreDbInitializer());
        //}
        //public WarehouseDataContext(string connectionString)
        //    : base(connectionString)
        //{
        //}
    }

    //public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<WarehouseDataContext>
    //{
    //    protected override void Seed(WarehouseDataContext db)
    //    {
    //        //db.Phones.Add(new Phone { Name = "Nokia Lumia 630", Company = "Nokia", Price = 220 });
    //        //db.Phones.Add(new Phone { Name = "iPhone 6", Company = "Apple", Price = 320 });
    //        //db.Phones.Add(new Phone { Name = "LG G4", Company = "lG", Price = 260 });
    //        //db.Phones.Add(new Phone { Name = "Samsung Galaxy S 6", Company = "Samsung", Price = 300 });
    //        db.SaveChanges();
    //    }
    //}
}
