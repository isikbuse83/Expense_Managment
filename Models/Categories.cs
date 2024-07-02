using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Management.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Category { get; set; }

        public ICollection<UserExpense> UserExpenses { get; set; } = new List<UserExpense>();
            }
}
