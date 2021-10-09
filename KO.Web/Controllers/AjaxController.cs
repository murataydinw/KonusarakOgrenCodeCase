using KO.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KO.Web.Controllers
{
    [Route("Ajax")]
    public class AjaxController : BaseWebController
    {
        private readonly IExamService _examService;
        public AjaxController(IExamService examService)
        {
            _examService = examService;
        }
        [Route("ExamResult")]
        public IActionResult ExamResult(int Id)
        {
            var model = _examService.ExamResult(Id);
            return Json(model);
        }
    }
}
