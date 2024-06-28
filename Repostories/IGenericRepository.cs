using Expense_Managment.Models;
using System.Linq.Expressions;

namespace Expense_Managment.Repostories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();

        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
        Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate);
        Task<bool> Update(UserExpense entity);
        Task<bool> GetById(UserExpense id );
        
    }
   
}
