using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Rectangle:Shape// rectangle class implements shape interface
    {
        int a = 0, b = 0;
        public void drawShape(string[] res, Graphics g, int k, int l, int radius, int width, int height)
        {
            if(width!=0 && height!=0)
            {
                a = width;
                b = height;
            }
            else
            {
                try
                {
                    a = Convert.ToInt32(res[1]);
                    b = Convert.ToInt32(res[2]);
                }
                catch(Exception e)
                {

                }
 
            }
            Pen p = new Pen(Color.Bisque, 3);
            g.DrawRectangle(p, k, l, a, b);
        }
    }
}
