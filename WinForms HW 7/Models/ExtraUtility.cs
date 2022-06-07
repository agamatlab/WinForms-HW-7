using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_HW_7.Enums;

namespace WinForms_HW_7.Models
{
    public static class ExtraUtility
    {
        public static Position GetPosition(string position)
            => position switch
            {
                "GK" => Position.GK,
                "F" => Position.F,
                "DD" => Position.DD,
                "MD" => Position.MD
            };
    }
}
