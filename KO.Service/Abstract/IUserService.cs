using KO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Service.Abstract
{
   public interface IUserService
    {
        User Get(string email, string password);
        User AddOrUpdate(User model);       
    }
}
