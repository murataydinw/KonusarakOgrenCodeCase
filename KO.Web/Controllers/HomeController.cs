using KO.Entities.Entities;
using KO.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {            
            var model = new User {Name="Murat",Surname="Aydin",Email="murataydinw@gmail.com",Password="123" };
           var result= _userService.AddOrUpdate(model);
            return View();
        }
    }
}
