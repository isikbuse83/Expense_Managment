namespace Expense_Managment.Models
{
    public class UserExpense
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Expense_Category_Id { get; set; }
        public string Report { get; set; }
        public decimal Total { get; set; }

        public User User { get; set; }
    }
}
