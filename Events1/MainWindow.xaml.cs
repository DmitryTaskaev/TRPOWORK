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

namespace Events1
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = CB.SelectedIndex;

            switch (item)
            {
                case 0:
                    Pages.RoutingPage page = new Pages.RoutingPage();
                    MainFrame.Navigate(page);
                    break;
                case 1:
                    Pages.AttacheEventsPage page1 = new Pages.AttacheEventsPage();
                    MainFrame.Navigate(page1);
                    break;
                case 2:
                    Pages.TextBoxPage page2 = new Pages.TextBoxPage();
                    MainFrame.Navigate(page2);
                    break;
                case 3:
                    Pages.ValidationInputPage page3 = new Pages.ValidationInputPage();
                    MainFrame.Navigate(page3);
                    break;
            }
        }
    }
}
