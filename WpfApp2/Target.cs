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
        public  Canvas canvas = new Canvas();


        public bool Flag=true;
        public double Rand()
        {
            Random rnd = new Random();
            int value = rnd.Next(0, 300);
            return value;
        }
        public void DrawTarget()
        {
            Ellipse myEl = new Ellipse();
            canvas.Children.Add(myEl);
            myEl.Stroke = System.Windows.Media.Brushes.White;
            myEl.Fill = System.Windows.Media.Brushes.DarkBlue;
            myEl.Width = 50;
            myEl.Height = 50;
            myEl.Visibility = Visibility;
            Canvas.SetZIndex(myEl, 1);
            Canvas.SetTop(myEl,250);
            Canvas.SetLeft(myEl, 750);
            
        }
        public bool IsHit(Canvas FlyObject,Canvas StaticObject)
        {
            double k = Canvas.GetTop(FlyObject.Children[0]);
            double f = Canvas.GetTop(StaticObject.Children[0]);
            double f2 = Canvas.GetLeft(FlyObject.Children[0]);
            double f1 = Canvas.GetLeft(StaticObject.Children[0]);


            if (Math.Abs(f-k) < 50)
            {

                if (Math.Abs(f2-f1) < 50)
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
