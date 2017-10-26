using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;



namespace dojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Errors = new List<string>();

            return View();

        }

        [HttpPost]
        [Route("process")]
        public IActionResult Process(string Name, string location, string language, string comment)
        {
            ViewBag.Errors = new List<string>();

            if(Name == null)
            {
                ViewBag.Errors.Add("Name can't be empty");
            }

            if(location == null)
            {
                ViewBag.Errors.Add("location can't be empty");
            }

            if(language == null)
            {
                ViewBag.Errors.Add("prgamming langugage can't be empty");
            }

            if(ViewBag.Errors.Count > 0)
            {
                return View("Index");
            }

            ViewBag.Name = Name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.comment = comment;

            return View("Success"); 
        }
    }
}