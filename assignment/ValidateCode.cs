using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assignment
{
    public class ValidateCode
    {
        public string[] valid(String text)
        {
            string xPoint, yPoint, zPoint;
            string[] rPoint = { };
            string[] sText = text.Split(',', ' ');
            try                                     //try block
            {
                if (sText[0].ToUpper() == "MOVETO") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1].Equals("a") && sText[2].Equals("b"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);// converts string value to integer and stores into variable
                            int y = Convert.ToInt32(sText[2]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);
                        }
                        string[] sPoint = { "moveTo", xPoint, yPoint };// stores in array
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box

                    }
                }
                if (sText[0].ToUpper() == "LOOP") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 3)
                    {
                        int x = Convert.ToInt32(sText[2]);// converts string value to integer and stores into variable
                        xPoint = Convert.ToString(x);
                        string[] sPoint = { "loop", xPoint };// stores in array
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "END") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 1)
                    {
                        string[] sPoint = { "end" };// stores in array
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "ENDMETHOD") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 1)
                    {
                        string[] sPoint = { "endmethod" };// stores in array
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "ENDIF") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 1)
                    {
                        string[] sPoint = { "endif" };// stores in array
                        rPoint = sPoint;
                    }
                    
                   
                }
                if (sText[0].ToUpper() == "IF") // converts aplhabets to uppercase and condition is checked
                {
                    string shap;
                    string sym;
                    if (sText.Length == 5)
                    {
                        int x = Convert.ToInt32(sText[3]);// converts string value to integer and stores into variable
                        if (sText[2] == "=" || sText[2] == ">" || sText[2] == "<")
                        {
                            sym = sText[2];
                            shap = sText[1];
                            xPoint = Convert.ToString(x);
                            string[] sPoint = { "if", shap, sym, xPoint };// stores in array
                            rPoint = sPoint;
                        }
                        else
                        {
                            MessageBox.Show("Invalid symbol");
                        }
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "DRAWTO")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1].Equals("a") && sText[2].Equals("b"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            int y = Convert.ToInt32(sText[2]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);

                        }
                        string[] sPoint = { "drawTo", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "RECTANGLE")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1].Equals("width") && sText[2].Equals("height"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                            string[] sPoint = { "rectangle", xPoint, yPoint };
                            rPoint = sPoint;
                        }
                    }
                    else if (sText.Length == 5)
                    {
                        if (sText[1] == "(" && sText[4] == ")")
                        {
                            xPoint = Convert.ToString(sText[2]);
                            yPoint = Convert.ToString(sText[3]);
                            string[] sPoint = { "rectangle", xPoint, yPoint };
                            rPoint = sPoint;
                        }
                    }
                    else
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = Convert.ToString(x);
                        yPoint = Convert.ToString(y);
                        string[] sPoint = { "rectangle", xPoint, yPoint };
                        rPoint = sPoint;
                    }

                }
                if (sText[0].ToUpper() == "TRIANGLE")
                {
                    if (sText.Length == 4)
                    {
                        if (sText[1].Equals("base") && sText[2].Equals("adj") && sText[3].Equals("hyp"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                            zPoint = sText[3];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            int y = Convert.ToInt32(sText[2]);
                            int z = Convert.ToInt32(sText[3]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);
                            zPoint = Convert.ToString(z);
                        }
                        string[] sPoint = { "triangle", xPoint, yPoint, zPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "CIRCLE")
                {
                    if (sText.Length == 2) 
                    {
                        if (sText[1].Equals("radius"))
                        {
                            xPoint = sText[1];   
                        }
                        else
                        {
                               int x = Convert.ToInt32(sText[1]);
                                xPoint = Convert.ToString(x);
                       
                        }
                        string[] sPoint = { "circle", xPoint };

                        rPoint = sPoint;


                    }
                    
                }

                   
                   
                if (sText[0].ToUpper() == "MYCIRCLE")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1] == "(" && sText[2] == ")")
                        {
                            string[] sPoint = { "mycircle" };
                            rPoint = sPoint;
                        }
                    }
                }

                if (sText[0].ToUpper() == "MYRECTANGLE")
                {
                    if (sText.Length == 5)
                    {
                        if (sText[1] == "(" && sText[4] == ")")
                        {
                            int x = Convert.ToInt32(sText[2]);
                            int y = Convert.ToInt32(sText[3]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);
                            string[] sPoint = { "myrectangle", xPoint, yPoint };
                            rPoint = sPoint;
                        }
                    }
                }


                if (sText[0].ToUpper() == "MYCIRCLE")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1] == "(" && sText[2] == ")")
                        {
                            string[] sPoint = { "mycircle" };
                            rPoint = sPoint;
                        }
                    }
                }

                if (sText[0].ToUpper() == "SQUARE")
                {
                    if (sText.Length == 2)
                    {
                        if (sText[1].Equals("side"))
                        {
                            xPoint = sText[1];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            xPoint = Convert.ToString(x);
                        }
                        string[] sPoint = { "square", xPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "TRANSFORM")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1].Equals("xpoint") && sText[2].Equals("ypoint"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            int y = Convert.ToInt32(sText[2]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);
                        }
                        string[] sPoint = { "transform", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "RADIUS" && sText[1] == "=")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] sPoint = { "radius", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "WIDTH" && sText[1] == "=")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        yPoint = Convert.ToString(y);
                        xPoint = sText[1];
                        string[] sPoint = { "width", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "HEIGHT" && sText[0] == "=")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] sPoint = { "height", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "RADIUS" && sText[1] == "+")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] sPoint = { "radius", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }


                if (sText[0].ToUpper() == "WIDTH" && sText[1] == "+")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] sPoint = { "width", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "HEIGHT" && sText[1] == "+")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] sPoint = { "height", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "METHOD")
                {
                    if (sText[1].ToUpper() == "MYRECTANGLE")
                    {
                        if (sText.Length == 6)
                        {
                            if (sText[2] == "(" && sText[5] == ")")
                            {
                                string a1 = Convert.ToString(sText[1]);
                                string xaxis = Convert.ToString(sText[3]);
                                string yaxis = Convert.ToString(sText[4]);
                                string[] k = { "method", a1, xaxis, yaxis };
                                rPoint = k;
                            }
                        }
                    }
                    else if (sText[1].ToUpper() == "MYCIRCLE")
                    {
                        if (sText.Length == 4)
                        {
                            if (sText[2] == "(" && sText[3] == ")")
                            {
                                string a1 = Convert.ToString(sText[1]);
                                string[] k = { "method", a1 };
                                rPoint = k;
                            }
                        }
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                    }
                }






            }
            catch (FormatException e) // catches incorrect format in code
            {
                string[] sPoint = { "1", "1" };
                rPoint = sPoint;
                MessageBox.Show(e.Message);

            }
            catch (IndexOutOfRangeException o)
            {

            }
            return rPoint;
        }

    }

}
