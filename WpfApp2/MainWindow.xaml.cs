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
        protected int score = 0;

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

        
            var mc = new Class1(num_Angle, num_Velosity);
            var target = new Target();

            mc.Time(str_Angle, str_Velosity);
            mc.Fly(str_Angle, str_Velosity);
            mc.Epsilon_Round(str_Angle, str_Velosity);
            

            double i = 0;
            while (true)
            {
                    target.DrawTarget();
                
                double Max_Distance = ((mc.FlyOnCordX(str_Angle, str_Velosity, i)) + 230);
                double Max_Fly = 300 - (mc.FlyOnCordY(str_Angle, str_Velosity, i));
                await Task.Delay(5);
                if ((Max_Distance <= 750) && (Max_Fly <= 350) && (Max_Fly > 0))
                {
                    Canvas.SetTop(Bird, Max_Fly);
                    Canvas.SetLeft(Bird, Max_Distance);
                    if (target.IsHit(Bird1, target.canvas))
                    {
                        score++;
                        System.Windows.Forms.MessageBox.Show("А");
                        break;
                    }
                }
                else
                {
                   System.Windows.Forms.MessageBox.Show("Промах");
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

