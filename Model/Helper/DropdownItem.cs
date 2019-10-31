using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Helper
{
    public interface DropdownItem
    {
        string DropdownValue();
        string DropdownText();
        bool DropdownItemEnabled();
    }
}
