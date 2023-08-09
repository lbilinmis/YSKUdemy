using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YSKUdemy.BankApp.Data.Contexts;
using YSKUdemy.BankApp.Data.Interfaces;
using YSKUdemy.BankApp.Mappings;
using YSKUdemy.BankApp.Models;

namespace YSKUdemy.BankApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private readonly AppDbContext _appDbContext;
        private readonly IAppUserRepository _userRepository;
        private readonly IAppUserMapping _appUserMapping;

        public HomeController(ILogger<HomeController> logger, /*AppDbContext appDbContext,*/ IAppUserRepository userRepository, IAppUserMapping appUserMapping)
        {
            _logger = logger;
            //_appDbContext = appDbContext;
            _userRepository = userRepository;
            _appUserMapping = appUserMapping;
        }

        public IActionResult Index()
        {
            //var userList = _appDbContext.AppUsers.Select(x => new UserListViewModel()
            //{
            //    Id = x.Id,
            //    Name = x.Name,
            //    SurName = x.SurName
            //}).ToList();
            //return View(userList);

            var userList2 = _userRepository.GetAll();
            var mapViewModelList = _appUserMapping.MapToListofUserListModel(userList2);

            return View(mapViewModelList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}