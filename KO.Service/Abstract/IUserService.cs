using KO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Service.Abstract
{
   public interface IUserService
    {
        object Get(string email, string password);
        object AddOrUpdate(User model);       
    }
}
