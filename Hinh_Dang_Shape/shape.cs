using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Dang_Shape
{
    abstract class shape
    {
        protected double radius, length, width; // Bán kính, chiều dài, chiều rộng


        public abstract Double Area();          // Tính diện tích
        public abstract Double Cirumference();  // Tính chu vi
    }
}
