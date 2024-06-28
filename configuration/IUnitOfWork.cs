using Expense_Managment.Repostories;

namespace Expense_Managment.configuration
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IUserExpense UserExpense{ get; }
       

        Task CompleteAsync();

        void Dispose();
    }
}
