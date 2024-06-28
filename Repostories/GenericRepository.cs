using Expense_Managment.Data;
using Expense_Managment.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Expense_Managment.Repostories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DataContext context;
        internal DbSet<T> dbSet;
        protected readonly ILogger _logger;

        public GenericRepository(DataContext context, ILogger logger)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
            this._logger = logger;
        }

        public Task<IEnumerable<T>> All()
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await dbSet.Where(predicate).ToListAsync();
        }

        public Task<bool> Update(UserExpense entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetById(UserExpense id)
        {
            throw new NotImplementedException();
        }
    }
}

//database tarafında yapılacak belli başlı crud işlemlerini her repository de tek tek yazmaktansa generig repository oluşturduk ve bu sayede bunları tek elden yönetiyoruz.