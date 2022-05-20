using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Runtime;
using System.Drawing;

namespace WpfApp2
{
   

    public class Target:Window
    {
        
        public bool Flag=true;
        public double RandSwitch(Canvas Alone)
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 300);
            Canvas.SetTop(Alone.Children[1], value);
            return value;
        }
       
        public bool IsHit(Canvas Alone)
        {
            double k = Canvas.GetTop(Alone.Children[0]);
            double f = Canvas.GetTop(Alone.Children[1]);
            double f2 = Canvas.GetLeft(Alone.Children[0]);
            double f1 = Canvas.GetLeft(Alone.Children[1]);


            if (Math.Abs(f-k) < 30)
            {

                if (Math.Abs(f2-f1) < 30)
                {
                    Flag = false;

                    return true;

                }

                  
                else return false;
            }
            else return false;
        }

    }
    
}
