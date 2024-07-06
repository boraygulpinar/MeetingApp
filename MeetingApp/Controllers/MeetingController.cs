using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo userInfo)
        {
            Repository.CreateUser(userInfo);
            ViewBag.UserCount = Repository.Users.Where(x=>x.WillAttend==true).Count();
            return View("Thanks",userInfo);
        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }
    }
}
