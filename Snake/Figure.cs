using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> plist;

        public void Draw_F()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
