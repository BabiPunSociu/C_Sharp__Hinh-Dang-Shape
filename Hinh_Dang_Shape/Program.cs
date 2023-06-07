using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Dang_Shape
{
    class Program
    {
        public static void Main()
        {
            // Hình tròn
            Circle hinhTron = new Circle(1);
            Console.WriteLine("Dien tich hinh tron: " + hinhTron.Area());
            Console.WriteLine("Chu vi hinh tron: " + hinhTron.Cirumference());

            // Hình chữ nhật
            Rectangle hinhChuNhat = new Rectangle(3, 4);
            Console.WriteLine("Dien tich hinh chu nhat: " + hinhChuNhat.Area());
            Console.WriteLine("Chu vi hinh chu nhat: " + hinhChuNhat.Cirumference());
        }
    }
}