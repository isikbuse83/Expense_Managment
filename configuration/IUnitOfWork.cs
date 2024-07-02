using Expense_Management.Repostories;
using Expense_Managment.Repostories;

namespace Expense_Management.configuration
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IUserExpense UserExpense{ get; }
       

        Task CompleteAsync();

        void Dispose();
    }
}
