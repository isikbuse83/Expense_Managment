using Expense_Managment.Models;

namespace Expense_Managment.Repostories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<IEnumerable<User>> All();
    }
}
//belli başlı crud işlemleriyle alakalı metotları tekrar tekrar yazmamamk için user repository i generic repository i miras aldık.