using Expense_Management.Models;

namespace Expense_Management.Repostories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<IEnumerable<User>> All();
    }
}
//belli başlı crud işlemleriyle alakalı metotları tekrar tekrar yazmamamk için user repository i generic repository i miras aldık.