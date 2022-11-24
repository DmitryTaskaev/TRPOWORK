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

namespace Navigation
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
            RegPage page = new RegPage();
            MainFrame.Navigate(page);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CatsPage page = new CatsPage();
            MainFrame.Navigate(page);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Uri google = new Uri("https://yandex.ru/");
            MainFrame.Navigate(google);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
