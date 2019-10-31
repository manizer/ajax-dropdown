using ajax_dropdown.Helper.ViewComponentHelpers;
using ajax_dropdown.ViewModels.HomeViewModels.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Model.StudentDomain;

namespace ajax_dropdown.ViewComponents.HomeViewComponent
{
    public class StudentsTable : ViewComponent
    {
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, ClassId = 1, Nama = "John" },
            new Student { Id = 2, ClassId = 1, Nama = "Toni" },
            new Student { Id = 3, ClassId = 2, Nama = "Glenn" },
            new Student { Id = 4, ClassId = 2, Nama = "Owen" },
            new Student { Id = 5, ClassId = 2, Nama = "Jonathan" },
            new Student { Id = 6, ClassId = 3, Nama = "Felix" },
            new Student { Id = 7, ClassId = 3, Nama = "Kenny" },
            new Student { Id = 8, ClassId = 3, Nama = "Steven" },
            new Student { Id = 9, ClassId = 3, Nama = "Marcus" },
            new Student { Id = 9, ClassId = 4, Nama = "Mary" }
        };
        public async Task<IViewComponentResult> InvokeAsync(int ClassId)
        {
            List<Student> students = GetStudentsByClassId(ClassId).ToList();
            return View(ViewComponentPath.ViewPath("Home", "_StudentsTable"), new StudentsTableViewModel
            {
                ClassId = ClassId,
                Students = students
            });
        }
        private IEnumerable<Student> GetStudentsByClassId(int classId) => students
            .Where(x => x.ClassId == classId).ToList();
    }
}
