using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCodeSample.BLL.ICollection;
using Microsoft.AspNetCore.Mvc;

namespace DemoCodeSample.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View(_user.Users());
        }
        public IActionResult Detail(int Id)
        {
            return View(_user.Users(Id));
        }
        public IActionResult Update(int Id)
        {
            return View(_user.Users(Id));
        }
        public IActionResult UpdateUser(DAL.User user)
        {

            _user.Update(user);
            return RedirectToAction("Users");
        }
        public IActionResult Add()
        {
           
            return View();
        }
        public IActionResult Save(DAL.User user)
        {
            _user.Add(user);
         return    RedirectToAction("Users");
        }
        public IActionResult Delete(int Id)
        {
            _user.Delete(Id);
           return RedirectToAction("Users");
        }
    }
}