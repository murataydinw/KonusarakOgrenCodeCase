using KO.Dal.EntityFramework;
using KO.Entities.Entities;
using KO.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KO.Service.Concrete
{
    public class ExamService : IExamService
    {
        public bool Delete(int Id)
        {
            using var context = new EfContext();
            var model = context.Exams.FirstOrDefault(x => x.Id == Id);
            if(model!=null)
            {
                context.Exams.Remove(model);
                context.SaveChanges();
                return true;
            }
           
            return false;
        }

        public object ExamResult(int Id)
        {
            using var context = new EfContext();
            var model = context.Exams.Where(x => x.Id == Id).Select(x => new
            {
                x.QOneTrue,
                x.QTwoTrue,
                x.QThreeTrue,
                x.QFourTrue
            }).ToList();
            return model;
        }

        public Exam Get(int Id)
        {
            using var context = new EfContext();
            var model = context.Exams.Select(x => new Exam
            {
                Id = x.Id,
                Title = x.Title,
                Body = x.Body,
                QuestionOne = x.QuestionOne,
                QuestionTwo = x.QuestionTwo,
                QuestionThree = x.QuestionThree,
                QuestionFour = x.QuestionFour,
                QOneAOne = x.QOneAOne,
                QOneATwo = x.QOneATwo,
                QOneAThree = x.QOneAThree,
                QOneAFour = x.QOneAFour,
                QOneTrue = x.QOneTrue,
                QTwoAOne = x.QTwoAOne,
                QTwoATwo = x.QTwoATwo,
                QTwoAThree = x.QTwoAThree,
                QTwoAFour = x.QTwoAFour,
                QTwoTrue = x.QTwoTrue,
                QThreeAOne = x.QThreeAOne,
                QThreeATwo = x.QThreeATwo,
                QThreeAThree = x.QThreeAThree,
                QThreeAFour = x.QThreeAFour,
                QThreeTrue = x.QThreeTrue,
                QFourAOne = x.QFourAOne,
                QFourATwo = x.QFourATwo,
                QFourAThree = x.QFourAThree,
                QFourAFour = x.QFourAFour,
                QFourTrue = x.QFourTrue,
                CreatedDate = x.CreatedDate,

            }).FirstOrDefault(x => x.Id == Id);
            return model;
        }
        public List<Exam> GetList()
        {
            using var context = new EfContext();
            var model = context.Exams.Select(x => new Exam
            {
                Id = x.Id,
                Title = x.Title,
                Body = x.Body,
                QuestionOne = x.QuestionOne,
                QuestionTwo = x.QuestionTwo,
                QuestionThree = x.QuestionThree,
                QuestionFour = x.QuestionFour,
                QOneAOne = x.QOneAOne,
                QOneATwo = x.QOneATwo,
                QOneAThree = x.QOneAThree,
                QOneAFour = x.QOneAFour,
                QOneTrue = x.QOneTrue,
                QTwoAOne = x.QTwoAOne,
                QTwoATwo = x.QTwoATwo,
                QTwoAThree = x.QTwoAThree,
                QTwoAFour = x.QTwoAFour,
                QTwoTrue = x.QTwoTrue,
                QThreeAOne = x.QThreeAOne,
                QThreeATwo = x.QThreeATwo,
                QThreeAThree = x.QThreeAThree,
                QThreeAFour = x.QThreeAFour,
                QThreeTrue = x.QThreeTrue,
                QFourAOne = x.QFourAOne,
                QFourATwo = x.QFourATwo,
                QFourAThree = x.QFourAThree,
                QFourAFour = x.QFourAFour,
                QFourTrue = x.QFourTrue,
                CreatedDate = x.CreatedDate

            }).Where(x => true).OrderByDescending(x => x.Id).ToList();
            return model;
        }
        public Exam Save(Exam command)
        {
            using var context = new EfContext();
            var model = new Exam();

            model.Title = command.Title;
            model.Body = command.Body;
            model.QuestionOne = command.QuestionOne;
            model.QuestionTwo = command.QuestionTwo;
            model.QuestionThree = command.QuestionThree;
            model.QuestionFour = command.QuestionFour;
            model.QOneAOne = command.QOneAOne;
            model.QOneATwo = command.QOneATwo;
            model.QOneAThree = command.QOneAThree;
            model.QOneAFour = command.QOneAFour;
            model.QOneTrue = command.QOneTrue;
            model.QTwoAOne = command.QTwoAOne;
            model.QTwoATwo = command.QTwoATwo;
            model.QTwoAThree = command.QTwoAThree;
            model.QTwoAFour = command.QTwoAFour;
            model.QTwoTrue = command.QTwoTrue;
            model.QThreeAOne = command.QThreeAOne;
            model.QThreeATwo = command.QThreeATwo;
            model.QThreeAThree = command.QThreeAThree;
            model.QThreeAFour = command.QThreeAFour;
            model.QThreeTrue = command.QThreeTrue;
            model.QFourAOne = command.QFourAOne;
            model.QFourATwo = command.QFourATwo;
            model.QFourAThree = command.QFourAThree;
            model.QFourAFour = command.QFourAFour;
            model.QFourTrue = command.QFourTrue;
            model.CreatedDate = DateTime.Now.ToString();

            context.Exams.Add(model);

            context.SaveChanges();

            return model;
        }
    }
}
