using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Dang_Shape
{
    class Rectangle : shape    // Hình chữ nhật
    {
        public Rectangle(double a, double b)
        {
            this.length = a;
            this.width = b;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Cirumference()
        {
            return 2*(length + width);
        }
    }
}
