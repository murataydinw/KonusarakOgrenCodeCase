using KO.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entities.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
