using Expense_Managment.Models;
using Microsoft.EntityFrameworkCore;
namespace Expense_Managment.Data
{

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base  (options)
        {

        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserExpense> UserExpenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }


    // database tablolarını yönetmek için db context classını oluşturduk 











}
