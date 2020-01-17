using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class Factory
    {
        public Shape getShape(string case)
        {
            case = case.ToUpper().Trim();//method that change lowercase charcter to upper case character and also trims the white sapces
            
            if (case.Equals("rectangle"))
            {
                return new Rectangle();
            }
            else if(case.Equals("triangle"))
            {
                return new Triangle();
            }
            else if(case.Equals("circle"))
            {
                return new Circle();
            }
            else if (case.Equals("square"))
            {
                return new Square();
            }
            return null;
        }
    }
}
