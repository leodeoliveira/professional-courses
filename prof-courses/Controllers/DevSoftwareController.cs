using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProfCourses.Models;
using ProfCourses.Models.Enums;
using ProfCourses.Models.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProfCourses.Controllers
{
    public class DevSoftwareController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentViewModel model)
        {
            if (ModelState.IsValid)
            {
                CreateStudent(model);
            }

            return View(model);
        }

        public Student CreateStudent(StudentViewModel model)
        {
            if (model != null)
            {
                model.Course = CoursesEnum.DevSoftware;
                Student student = new Student();
                student.ClassesMapper(model);
                return student;
            }
            return null;
        }
    }
}
