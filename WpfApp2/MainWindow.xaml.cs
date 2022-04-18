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
using System.Windows.Media;
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


        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string str_Velosity = Convert.ToString(str_velosity.Text);
            string str_Angle = Convert.ToString(str_angle.Text);
            if ((int.TryParse(str_velosity.Text, out int _Velosity))&&(int.TryParse(str_angle.Text, out int _Angle)
                )){
                MessageBox.Show("успешный ввод цифр");
            }
            else MessageBox.Show("Ошибка");

            double num_Angle = Convert.ToDouble(str_Angle);
            double num_Velosity = Convert.ToDouble(str_Velosity);
        //    double time_tarvel = 2 * num_Velosity * Math.Sin(num_Angle)/9.8;
            var mc = new Class1(num_Angle, num_Velosity);
            mc.Time(str_Angle, str_Velosity);
            mc.Fly(str_Angle, str_Velosity);
            foreach (int i in mc.Timer)
                Cord_x.Children.Add(new Label { Content = mc.cord_x[i] });

            foreach (int i in mc.Timer)
                Cord_y.Children.Add(new Label { Content = Content = mc.cord_y[i] });


        }
        public MainWindow()
        {

            InitializeComponent();
        }
        

    }

}
