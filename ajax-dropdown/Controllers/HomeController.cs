using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ajax_dropdown.ViewModels.HomeViewModels;
using Microsoft.AspNetCore.Mvc;
using static Model.StudentDomain;
using ajax_dropdown.ViewModels.HomeViewModels.Components;
using ajax_dropdown.Helper.DropdownHelpers;

namespace ajax_dropdown.Controllers
{
    public class HomeController : Controller
    {
        List<Class> classes = new List<Class>
        {
            new Class { Id = 1, ClassName = "LA06" },
            new Class { Id = 2, ClassName = "LH01" },
            new Class { Id = 3, ClassName = "CL02" },
            new Class { Id = 4, ClassName = "BA02" }
        };
        public IActionResult Index()
        {
            List<Class> classes = this.classes;
            return View(new IndexViewModel()
            {
                ClassId = 1,
                ClassSelectListItems = Dropdown.From(classes)
            });
        }

        [HttpPost]
        public IActionResult StudentsTableViewComponentOnSelect(StudentsTableViewModel studentsTableViewModel)
        {
            return ViewComponent("StudentsTable", studentsTableViewModel.ClassId);
        }
    }
}