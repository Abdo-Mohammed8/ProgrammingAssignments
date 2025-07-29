using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_oop_3.ClassesQ01
{
    public interface IRectangle : IShape
    {
        double Width { get; }
        double Height { get; }
    }
}
