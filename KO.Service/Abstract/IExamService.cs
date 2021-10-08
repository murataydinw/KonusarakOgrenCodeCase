using KO.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Service.Abstract
{
   public interface IExamService
    {
        Exam Get(int Id);
        List<Exam> GetList();
        Exam Save(Exam command);
    }
}
