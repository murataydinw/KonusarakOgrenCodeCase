using KO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.ViewModels
{
    public class ListPageModel
    {
        public List<Exam> Exams { get; set; }
        public string Message { get; set; }
    }
}
