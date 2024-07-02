using Expense_Management.Data;
using Expense_Management.Repostories;
using Expense_Managment.Repostories;

namespace Expense_Management.configuration
{
    public class UnitOfWork : IUnitOfWork, IDisposable

    {
        private readonly DataContext _context;
        private readonly ILogger _logger;

        public IUserRepository User { get; private set; }

     

        IUserExpense IUnitOfWork.UserExpense => throw new NotImplementedException();

        public UnitOfWork(DataContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            User = new UserRepository(context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
        public void Dispose() 
        {
            _context.Dispose(); 
        
        }

    }
}
