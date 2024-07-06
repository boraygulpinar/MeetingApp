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
            if (ModelState.IsValid)
            {
                Repository.CreateUser(userInfo);
                ViewBag.UserCount = Repository.Users.Where(x => x.WillAttend == true).Count();
                return View("Thanks", userInfo);
            }
            else 
            {
                return View(userInfo);
            }
        }

        [HttpGet]
        public IActionResult List()
        {
            var users = Repository.Users;
            return View(users);
        }

        //meeting/details/2
        [HttpGet]
        public IActionResult Details(int id)
        {
            var getId=Repository.GetById(id);
            return View(getId);
        }
    }
}
