using KO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.ViewModels
{
    public class HomePageModel
    {
        public List<Article> Articles { get; set; }
        public Exam Exam { get; set; } = new Exam();

    }
}
