using YSKUdemy.BankApp.Data.Contexts;
using YSKUdemy.BankApp.Data.Entities;
using YSKUdemy.BankApp.Data.Interfaces;

namespace YSKUdemy.BankApp.Data.Repositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly AppDbContext _context;

        public AppUserRepository(AppDbContext context)
        {
            _context = context;
        }


        //public List<AppUser> GetAll()
        //{
        //    return _context.AppUsers.ToList();
        //}

        public List<AppUser> GetAll()
        {
            return _context.Set<AppUser>().ToList();
        }

        public AppUser GetById(int id)
        {
            return _context.AppUsers.SingleOrDefault(x => x.Id == id);
        }

        public void Create(AppUser entity)
        {
            //_context.Accounts.Add(entity);
            _context.Set<AppUser>().Add(entity);
            _context.SaveChanges();
        }
    }
}
