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



namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void button1_Click(object sender, System.EventArgs e)
        {
            Form dlg1 = new Form();
            dlg1.ShowDialog();
        }

        public async void Button_Click(object sender, RoutedEventArgs e)
        {
            Cord_x.Children.Clear();
            Cord_y.Children.Clear();
            string str_Velosity;
            string str_Angle;

            while (true)
            {
                str_Velosity = Convert.ToString(str_velosity.Text);
                str_Angle = Convert.ToString(str_angle.Text);
                if (
                    (int.TryParse(str_velosity.Text, out int _Velosity))
                    &&
                    (Double.TryParse(str_angle.Text, out double _Angle)))
                    {
                    System.Windows.Forms.MessageBox.Show("успешный ввод цифр");
                        break;
                    }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Ошибка");
                    return;
                }
            }
          
            double num_Angle = Convert.ToDouble(str_Angle);
            double num_Velosity = Convert.ToDouble(str_Velosity);


        //    double time_tarvel = 2 * num_Velosity * Math.Sin(num_Angle)/9.8;

        
            var mc = new Class1(num_Angle, num_Velosity);
            

            mc.Time(str_Angle, str_Velosity);
            mc.Fly(str_Angle, str_Velosity);
            mc.Epsilon_Round(str_Angle, str_Velosity);
            /*
            Cord_x.Children.Add(new TextBlock { Text = "Coord_x" });
            Cord_y.Children.Add(new TextBlock { Text = "Coord_y" });
               for (int i = 0; i < mc.Timer.Count; ++i)
               {
                   Cord_x.Children.Add(new TextBlock { Text = Convert.ToString(mc.cord_x[i])});
                   Cord_y.Children.Add(new TextBlock { Text = Convert.ToString(mc.cord_y[i]) });
                   Cord_y.CanHorizontallyScroll = true;
                   Cord_x.CanHorizontallyScroll = true;
               }
            */

            double i = 0;
           // MessageBox.Show(Convert.ToString(Math.Cos(num_Angle)));
            while (true)
            {
                double Max_Distance = ((mc.FlyOnCordX(str_Angle, str_Velosity, i)) + 230);
                double Max_Fly = 300 - (mc.FlyOnCordY(str_Angle, str_Velosity, i));
                await Task.Delay(5);
                if ((Max_Distance <= 750) && (Max_Fly <= 350) && (Max_Fly > 0))
                {
                    Canvas.SetTop(Bird, Max_Fly);
                    Canvas.SetLeft(Bird, Max_Distance);
                }
                else
                {
                   System.Windows.Forms.MessageBox.Show("Вылет за грицу мира");
                    return;
                }
                i += 0.04;
            }
                  


            
            

            
           
        }

        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }

}

