using Expense_Management.Models;
using Microsoft.EntityFrameworkCore;
namespace Expense_Management.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base  (options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserExpense> UserExpenses { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Report> Reports { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Report>().HasNoKey();
        }

    }


    // database tablolarını yönetmek için db context classını oluşturduk 











}
