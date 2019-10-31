using Microsoft.AspNetCore.Mvc.Rendering;
using Model.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajax_dropdown.Helper.DropdownHelpers
{
    public class Dropdown
    {
        public static List<SelectListItem> From(IEnumerable<DropdownItem> dropdownItems) => dropdownItems
            .Where(x => x != null)
            .Select(x =>
            new SelectListItem
            {
                Text = x.DropdownText() ?? "",
                Value = x.DropdownValue()
            })
            .ToList();
    }
}
