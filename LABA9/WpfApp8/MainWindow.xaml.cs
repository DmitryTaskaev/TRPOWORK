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
using WpfApp8.Pages;

namespace WpfApp8
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

        private void LabelBindingPropertiesMouseClick(object sender, MouseButtonEventArgs e)
        {
            UserPage userPage = new UserPage();
            MainFrame.Navigate(userPage);
        }

        private void LabelBindingCollectionsMouseClick(object sender, MouseButtonEventArgs e)
        {
            AllUsersPage userPage = new AllUsersPage();
            MainFrame.Navigate(userPage);
        }
    }
}
