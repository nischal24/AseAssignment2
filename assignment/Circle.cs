using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    ///<summary>
    /// circle class implements the shape interface 
    ///<summary>
    
    class Circle : Shape//circle class implements shape interface
    {
        int a=0, b=0;
        public void drawShape(string[] res, Graphics g, int k, int l, int radius, int width, int height)
        {  
            if(radius!=0)
            {
                a = radius;
                b = radius;
            }

            else
            {
                MessageBox.Show(res[1]);
                a = Convert.ToInt32(res[1]);
                b = Convert.ToInt32(res[1]);
            }
          
            Pen p = new Pen(Color.Bisque, 3);
            g.DrawEllipse(p, k, l, a,b);
        }
    }
}
