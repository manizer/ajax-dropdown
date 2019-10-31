using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ajax_dropdown.Helper.ViewComponentHelpers
{
    public class ViewComponentPath
    {
        public static string ViewPath(string ModuleName, string ViewName) => $"~/Views/{ModuleName}/Components/{ViewName}.cshtml";
    }
}
