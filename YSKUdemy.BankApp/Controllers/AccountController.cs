using Microsoft.AspNetCore.Mvc;
using YSKUdemy.BankApp.Data.Contexts;
using YSKUdemy.BankApp.Data.Interfaces;
using YSKUdemy.BankApp.Data.Repositories;
using YSKUdemy.BankApp.Mappings;
using YSKUdemy.BankApp.Models;

namespace YSKUdemy.BankApp.Controllers
{
    public class AccountController : Controller
    {
        //private readonly AppDbContext _context;
        private readonly IAppUserRepository _userRepository;
        private readonly IAppUserMapping _userMapping;
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountMapping _accountMapping;

        public AccountController(/*AppDbContext context, */IAppUserMapping userMapping, IAppUserRepository userRepository, IAccountRepository accountRepository, IAccountMapping accountMapping)
        {
            //_context = context;
            //_userRepository = new AppUserRepository(_context);
            _userMapping = userMapping;
            _userRepository = userRepository;
            _accountRepository = accountRepository;
            _accountMapping = accountMapping;
        }

        public IActionResult Index()
        {
            return View();
        }



        [HttpGet]
        public IActionResult Create(int id)
        {
            //var userInfo = _context.AppUsers.Select(x => new UserListViewModel()
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    SurName = x.SurName
            //}).SingleOrDefault(x => x.Id == id);
            //return View(userInfo);

            var userInfo2 = _userRepository.GetById(id);
            var mapUserViewmodel = _userMapping.MapToofUserListModel(userInfo2);
            return View(userInfo2);
        }


        [HttpPost]
        public IActionResult Create(AccountCreateViewModel model)
        {
            //_context.Accounts.Add(new Data.Entities.Account()
            //{
            //    AccountNumber = model.AccountNumber,
            //    AppUserId = model.AppUserId,
            //    Balance = model.Balance,
            //});
            //_context.SaveChanges();

            var account=_accountMapping.Mapping(model);

            _accountRepository.Create(account);

            return RedirectToAction("Index", "Home");
        }

    }
}
