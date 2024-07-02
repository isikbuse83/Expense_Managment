using Microsoft.IdentityModel.Tokens;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Management.Models
{
    public class UserExpense
    {
        public int Id { get; private set; }
        public int UserId { get; set; }
        
        public int Expense_Category_Id { get; set; }
        public string  merchant { get; set; }
        public string Report { get; set; }
        public decimal Total { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey("Expense_Category_Id")]


        public virtual Categories category { get; set; }
        public User User { get; set; }
       
    }
}
