using PRACTICA_26_10.Pages;
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

namespace PRACTICA_26_10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
     
            /*AllUsersPage b = new AllUsersPage();
            MainFrame.Navigate(b);*/
        }

        private void Label1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            UserPage a = new UserPage();
            MainFrame.Navigate(a);
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            InitializeComponent();
            AllUsersPage a = new AllUsersPage();
            MainFrame.Navigate(a);
        }
    }
}
