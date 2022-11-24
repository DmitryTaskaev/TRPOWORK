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

namespace ComboBoxWPF
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

        private void resBtn_Click(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(Anumb.Text);
            double B = Convert.ToDouble(BNumb.Text);
            double result = 0;

            int numb = Convert.ToInt32(CB.SelectedIndex);

            switch (numb)
            {
                case 0:
                    result = A * B;
                    break;
                case 1:
                    result = A / B;
                    break;
                case 2:
                    result = A - B;
                    break;
                case 3:
                    result = A + B;
                    break;
                default:

                    break;
            }
            Result.Text = Convert.ToString(result);


            Lang l = new Lang();
            l.Show();
            this.Close();

        }
    }
}
