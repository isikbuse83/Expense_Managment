using Expense_Managment.Data;
using Expense_Managment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Client;
using System.Linq.Expressions;



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

    

