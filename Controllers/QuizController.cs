using MedicalQuiz.Models;
using MedicalQuiz.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalQuiz.Controllers
{
    public class QuizController : Controller
    {
        private readonly ILogger<QuizController> _logger;
        private readonly IQuizHelper QuizHelper;

        public QuizController(ILogger<QuizController> logger,
                              IQuizHelper quizHelper)
        {
            _logger     = logger;
            QuizHelper  = quizHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetQuiz(int id)
        {
            var _pageId = id;
            if (_pageId < 0)
                _pageId = 0;
            else if (_pageId >= QuizHelper.GetQuizCount())
                _pageId = QuizHelper.GetQuizCount()-1;

            var content = QuizHelper.GetQuiz(_pageId);
            return Json(content);
        }

        public IActionResult Submit(int id)
        {
            return Ok();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
