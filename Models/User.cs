using System;

namespace Expense_Managment.Models
{
    public class User
    {
        public int Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<UserExpense> UserExpenses { get; set; } = new List<UserExpense>();
    }
}



