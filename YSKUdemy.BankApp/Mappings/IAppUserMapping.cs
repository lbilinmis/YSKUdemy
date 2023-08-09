using YSKUdemy.BankApp.Data.Entities;
using YSKUdemy.BankApp.Models;

namespace YSKUdemy.BankApp.Mappings
{
    public interface IAppUserMapping
    {
        List<UserListViewModel> MapToListofUserListModel(List<AppUser> users);
        UserListViewModel MapToofUserListModel(AppUser user);
    }
}
