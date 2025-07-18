using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task_1.Company
{
    internal struct HireDate
    {
        public int Day, Month, Year;

        public HireDate(int d, int m, int y)
        {
            Day = d;
            Month = m;
            Year = y;
        }

        public override string ToString() => $"{Day}/{Month}/{Year}";
    }
}
