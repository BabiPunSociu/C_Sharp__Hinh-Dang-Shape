using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Dang_Shape
{
    class Circle : shape
    {
        public Circle(double r)
        {
            this.radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Cirumference()
        {
            return 2 * Math.PI * radius;
        }
    }
}
