using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Square : Shape
    {
        public void drawShape(string[] res, Graphics g, int k, int l, int radius, int width, int height)
        {
            int a = 0, b = 0;
            if (res[1].Equals("side"))
            {
                a = 50;
                b = 50;
            }
            else
            {
                a = Convert.ToInt32(res[1]);
                b = Convert.ToInt32(res[1]);
            }
            Pen p = new Pen(Color.Bisque, 3);
            g.DrawRectangle(p, k, l, a, b);
        }
    }
}
