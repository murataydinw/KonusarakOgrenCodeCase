﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.Model
{
    public class UserSession
    {
        public int Id { get; set; }       
        public string Name { get; set; }
        public string Surname { get; set; }        
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
