using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajax_dropdown.ViewModels.HomeViewModels
{
    public class IndexViewModel
    {
        public int ClassId { get; set; }
        public List<SelectListItem> ClassSelectListItems { get; set; }
    }
}
