using Expense_Management.Data;
using Expense_Management.Models;
using Expense_Management.Repostories;



namespace Expense_Managment.Repostories
{
    public class UserExpenseRepository : GenericRepository<UserExpense>, IUserExpense
    {
        public UserExpenseRepository(DataContext context, ILogger logger) : base(context, logger)
        {

        }
        public async Task<IEnumerable<UserExpense>> GetMyExpenses(int Id)
        {
            var allExpenses = await All();
            var myExpenses = allExpenses.Where(x => x.UserId == Id).ToList();
            return myExpenses;    
        }

    }

}

    

