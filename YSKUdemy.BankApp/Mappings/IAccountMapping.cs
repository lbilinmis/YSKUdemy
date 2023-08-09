using YSKUdemy.BankApp.Data.Entities;
using YSKUdemy.BankApp.Models;

namespace YSKUdemy.BankApp.Mappings
{
    public interface IAccountMapping
    {
        Account Mapping(AccountCreateViewModel model);
    }
}
