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

namespace FirstApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(TbA.Text);
            int b = Convert.ToInt32(TbB.Text);
            int c = Convert.ToInt32(TbC.Text);
            double x1;
            double x2;

            double res = Math.Pow(b, 2) - (4 * a * c);
            if (res < 0)
            {
                LResult.Content = "Корней нет";
            } else if(res == 0)
            {
                x1 = (-b + Math.Sqrt(res)) / (2 * a);
                LResult.Content = $"Корень: {x1}";
            }
            else if (res > 0)
            {
                x1 = (-b + Math.Sqrt(res)) / (2 * a);
                x2 = (-b - Math.Sqrt(res)) / (2 * a);
                LResult.Content = $"Корни: {x1}, {x2}";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _3Windows ww = new _3Windows();
            ww.Show();
            this.Close();
        }
    }
}
