using Assignment01_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_1
{
    static class ColorChecker
    {
        public static string IsPrimary(string color)
        {
            return Enum.TryParse(typeof(Colors), color, true, out _) ? "It is a primary color" : "Not a primary color";
        }
    }
}
