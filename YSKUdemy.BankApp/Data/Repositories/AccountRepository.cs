using YSKUdemy.BankApp.Data.Contexts;
using YSKUdemy.BankApp.Data.Entities;
using YSKUdemy.BankApp.Data.Interfaces;

namespace YSKUdemy.BankApp.Data.Repositories
{
    public class AccountRepository: IAccountRepository
    {
        private readonly AppDbContext _context;

        public AccountRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Account entity)
        {
            //_context.Accounts.Add(entity);
            _context.Set<Account>().Add(entity);
            _context.SaveChanges();
        }
    }
}
