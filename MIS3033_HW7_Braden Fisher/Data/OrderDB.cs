using Microsoft.EntityFrameworkCore;
using MIS3033_HW7_Braden_Fisher.Models;

namespace MIS3033_HW7_Braden_Fisher.Data
{
    public class OrderDB : DbContext// Change DbCon to your own database connect class name
    {
        public DbSet<Order> Orders { get; set; }// Define a table in the database. The table name here is: Students
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=129.15.67.240;Database=fish0090hw7db;Port=5432;Username=fish0090;Password=jFo9OvfVJ5QFHHspd1Au");
        }
    }


}
