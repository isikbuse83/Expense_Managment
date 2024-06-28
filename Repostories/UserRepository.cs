using Expense_Managment.Data;
using Expense_Managment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace Expense_Managment.Repostories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context, ILogger logger) : base(context, logger)
        {

        }

        public  async Task<IEnumerable<User>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "All fuction error", typeof(UserRepository));
                return new List<User>();
            }
        }
        public override async Task<bool> Update(User entity)
        {
            try
            {
                var existingUser = await dbSet.Where(x => x.Id == entity.Id)
                    .FirstOrDefaultAsync();
                if (existingUser == null)
                    return await Add(entity);

                
                existingUser.FirstName = entity.FirstName;
                existingUser.LastName = entity.LastName;
                existingUser.Email = entity.Email;
                existingUser.Password = entity.Password;

                return true;        
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "update function error", typeof(UserRepository));
                return false;
            }
        }

        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.Id == id)
                    .FirstOrDefaultAsync();

                if (exist == null) return false;
                dbSet.Remove(exist);

                return true;
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "delete function error.", typeof(UserRepository));
                return false;
            }
        }


    }

}
//userla alakalı database işlemleri için user repository oluşturduk. update ve delete gibi işlemlerde ekstra  kontroller eklemek için
//generic repositorydeki ilgili metotları override ettik.
   
