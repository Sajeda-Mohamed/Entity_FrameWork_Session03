using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FrameWork_Session03.InheretanceTest
{
    internal class PartTimeEmployee: Employee
    {
        public int CountOfHour { get; set; }
        public decimal HourRate { get; set; }
    }
}
