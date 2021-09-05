using InfApp.Data.Repository;
using InfApp.Models;
using InfApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITeacherRepository _repository;

        public HomeController(ITeacherRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            //List<Teacher> teachers = new List<Teacher>()
            //{
            //    new Teacher() {Name="James", Class="C# Programming"},
            //    new Teacher() { Name="Eliana", Class="Data Structure" },
            //    new Teacher() { Name="Edgar", Class="Modern Javascript"},
            //    new Teacher() { Name="Shan", Class="Project Management"}
            //};

            var teachers = _repository.GetAllTeachers();

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teachers = teachers
            };

            return View(viewModel);
        }

        // Get: /<Controller>/
        public IActionResult Student()
        {
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher() {Name="James", Class="C# Programming"},
                new Teacher() { Name="Eliana", Class="Data Structure" },
                new Teacher() { Name="Edgar", Class="Modern Javascript"},
                new Teacher() { Name="Shan", Class="Project Management"}
            };

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new Student(),
                Teachers = teachers
            };

            return View(viewModel);
        }

        //[HttpPost]
        //public IActionResult Student([Bind("Age", "Country")] Student model)
        //{

        //    return View();
        //}


        [HttpPost]
        [ValidateAntiForgeryToken] // compare user input
        //public IActionResult Student(Student model)
        public IActionResult Student(StudentTeacherViewModel model)
        {
            if (ModelState.IsValid)
            {
                // store model data into Student table

            }
            else
            {
                // display error
            }

            return View();
        }
    }
}
