using YSKUdemy.BankApp.Data.Entities;
using YSKUdemy.BankApp.Models;

namespace YSKUdemy.BankApp.Mappings
{
    public class AccountMapping: IAccountMapping
    {
        public Account Mapping(AccountCreateViewModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                AppUserId = model.AppUserId,
                Balance = model.Balance,
            };
        }
    }
}
