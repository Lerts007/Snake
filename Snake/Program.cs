using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Отрисовка рамки
            HorizontalLine Up_line = new HorizontalLine(0, 100, 0, '+');
            HorizontalLine Down_line = new HorizontalLine(0, 100, 25, '+');
            VerticalLine Left_line = new VerticalLine(0, 25, 0, '+');
            VerticalLine Right_line = new VerticalLine(0, 25, 100, '+');
            Up_line.Draw_F();
            Down_line.Draw_F();
            Left_line.Draw_F();
            Right_line.Draw_F();

            //Отрисовка точки
            Point p1 = new Point(10, 6, '*');
            p1.Draw();


            Point p2 = new Point(2, 5, '$');
            p2.Draw();

            Console.ReadLine();

        }
    }
}
