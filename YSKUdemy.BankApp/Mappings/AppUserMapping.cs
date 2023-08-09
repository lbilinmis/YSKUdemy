using YSKUdemy.BankApp.Data.Entities;
using YSKUdemy.BankApp.Models;

namespace YSKUdemy.BankApp.Mappings
{
    public class AppUserMapping: IAppUserMapping
    {
        public List<UserListViewModel> MapToListofUserListModel(List<AppUser> users)
        {
            return users.Select(x => new UserListViewModel()
            {
                Id = x.Id,
                Name = x.Name,
                SurName = x.SurName
            }).ToList();
        }


        public UserListViewModel MapToofUserListModel(AppUser user)
        {
            return new UserListViewModel()
            {
                Id = user.Id,
                Name = user.Name,
                SurName = user.SurName
            };
        }
    }
}
