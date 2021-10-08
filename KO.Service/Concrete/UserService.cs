using KO.Dal.EntityFramework;
using KO.Entities.Entities;
using KO.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KO.Service.Concrete
{
    public class UserService : IUserService
    {
        public User AddOrUpdate(User model)
        {
            using var context = new EfContext();      
            var user = model.Id > 0 ? context.Users.FirstOrDefault(x => x.Id == model.Id) : new User();
            if (user == null)
            {
                return null;
            }

            user.Name = model.Name;
            user.Surname = model.Surname;
            user.Email = model.Email;
            //user.IsActive = model.IsActive;           
            user.Password = !string.IsNullOrEmpty(model.Password) ? model.Password : user.Password;

            if (model.Id > 0)
            {               
                //user.UpdatedAt = DateTime.Now;
            }
            else
            {               
                context.Users.Add(user);
            }
            context.SaveChanges();            
           
            return model;
        }

        public User Get(string email, string password)
        {
            using var context = new EfContext();
            var user = context.Users.Select(x => new User
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,               
                Password = x.Password
            }).FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }
    }
}
