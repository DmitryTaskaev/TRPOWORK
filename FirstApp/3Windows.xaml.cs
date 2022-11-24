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
using System.Windows.Shapes;

namespace FirstApp
{
    /// <summary>
    /// Логика взаимодействия для _3Windows.xaml
    /// </summary>
    public partial class _3Windows : Window
    {
        public _3Windows()
        {
            InitializeComponent();
        }

        private void W1_Click(object sender, RoutedEventArgs e)
        {
            if(CB.IsChecked == true)
            {
                W1 w1 = new W1();
                w1.ShowDialog();
            }
            else
            {
                W1 w1 = new W1();
                w1.Show();
                w1.Close();
            }
        }

        private void W2_Click(object sender, RoutedEventArgs e)
        {
            if (CB.IsChecked == true)
            {
                W2 w2 = new W2();
                w2.ShowDialog();
            }
            else
            {
                W2 w2 = new W2();
                w2.Show();
                w2.Close();
            }
        }

        private void W3_Click(object sender, RoutedEventArgs e)
        {
            if (CB.IsChecked == true)
            {
                W3 w3 = new W3();
                w3.ShowDialog();
            }
            else
            {
                W3 w3 = new W3();
                w3.Show();
                w3.Close();
            }
        }
    }
}
