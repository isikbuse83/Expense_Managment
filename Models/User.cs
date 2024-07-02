using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Expense_Management.Models
{
    public class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public string Password{ get; set; }


        [ForeignKey("UserId")]
        public ICollection<UserExpense> UserExpenses { get; set; } = new List<UserExpense>();
    }
}



