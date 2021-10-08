using KO.Entities.Entities;
using KO.Service.Abstract;
using KO.Web.Helper;
using KO.Web.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.Controllers
{
    public class LoginController : BaseWebController
    {
        private readonly IUserService _userService;
        public LoginController(IUserService userService)
        {
            _userService = userService;
        }
        [Route("login")]
        public IActionResult Index()
        {
            var model = new LoginModel();
            return View(model);
        }
        [HttpPost]
        [Route("login")]
        public IActionResult Index(LoginModel command)
        {
            User user = null;

            user = _userService.Get(command.Email, command.Password);
            if (user == null)
            {
                command.Message = "Kullanıcı Bilgileri Hatalı";
                return View(command);
            }
            else
            {
                var userSession = new UserSession
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    Password = user.Password,

                };
                HttpContext.Session.SetSession("UserSession", userSession);
            }


            return Redirect("/");
        }
    }
}
