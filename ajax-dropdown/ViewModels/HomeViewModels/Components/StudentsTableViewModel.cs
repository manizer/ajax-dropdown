using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Model.StudentDomain;

namespace ajax_dropdown.ViewModels.HomeViewModels.Components
{
    public class StudentsTableViewModel
    {
        public int ClassId { get; set; }
        public List<Student> Students { get; set; }
    }
}
