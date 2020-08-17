using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestStore3.Models;
using QuestStore3.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Identity;

namespace QuestStore3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly QuestContext _context;
        private readonly AccountController _login;
        private readonly User _user;

        public HomeController(ILogger<HomeController> logger, QuestContext context, AccountController login, User user)
        {
            _logger = logger;
            _context = context;
            _login = login;
            _user = user;
        }

        public IActionResult Index()
        {
            return View();
            }

        public IActionResult Quests()
        {
            ViewData["list"] = _context.Quest.ToList();
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Quests(User user)
        //{
        //    return await _login.Login(user, HttpContext);
        //}

        public IActionResult Bonuses()
        {
            ViewData["list2"] = _context.Bonuse.ToList();
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Bonuses(User user)
        //{
        //    return await _login.Login(user, HttpContext);
        //}

        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Index(UserLogin userLogin)
        //{
        //    _user.Email = userLogin.Email;
        //    _user.Password = userLogin.Password;
        //    return await _login.Login(_user, HttpContext);
        //}


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
