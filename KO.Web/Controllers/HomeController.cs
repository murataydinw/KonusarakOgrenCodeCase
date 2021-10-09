using KO.Entities.Entities;
using KO.Service.Abstract;
using KO.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.Controllers
{
    public class HomeController : BaseWebController
    {
        private readonly IArticleService _articleService;
        private readonly IExamService _examService;
        public HomeController(IArticleService articleService, IExamService examService)
        {
            _articleService = articleService;
            _examService = examService;
        }

        [Route("/{Id?}")]
        public IActionResult Index(int? Id)
        {

            var model = new HomePageModel();
            model.Articles = _articleService.GetList();

            var selected = model.Articles.FirstOrDefault(x => (Id == null || x.Id == Id));
            if (selected != null)
            {
                model.Exam.Title = selected.Title;
                model.Exam.Body = selected.Body;
            }
            return View(model);
        }

        [Route("/exams")]
        public IActionResult List()
        {
            var model = new ListPageModel();
            model.Exams = _examService.GetList();
            return View(model);
        }

        [Route("/exams/delete/{id}")]
        public IActionResult Delete(int Id)
        {
            var model = new ListPageModel();
            var result = _examService.Delete(Id);
            if(result=true)
            {
                model.Message = "Silme İşlemi Başarılı";
            }
            
            model.Exams = _examService.GetList();
            return View("List",model);
        }
        [Route("/exams/{Id}")]
        public IActionResult Detail(int Id)
        {
            var model = new DetailPageModel();
            model.Exam = _examService.Get(Id);
            return View(model);
        }

        [HttpPost]
        public IActionResult SaveExam(Exam model)
        {
            var a = _examService.Save(model);
            return Redirect("/exams");
        }
            
    }
}
