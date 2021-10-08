using KO.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Entities.Entities
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
