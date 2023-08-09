using YSKUdemy.BankApp.Data.Entities;

namespace YSKUdemy.BankApp.Data.Interfaces
{
    public interface IAccountRepository
    {
        void Create(Account entity);
    }
}
