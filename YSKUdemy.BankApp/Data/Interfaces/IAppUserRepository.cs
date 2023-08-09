using YSKUdemy.BankApp.Data.Entities;

namespace YSKUdemy.BankApp.Data.Interfaces
{
    public interface IAppUserRepository
    {
        List<AppUser> GetAll();
        AppUser GetById(int id);
        void Create(AppUser entity);
    }
}
