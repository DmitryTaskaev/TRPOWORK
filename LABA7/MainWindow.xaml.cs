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
using practica_7.Pages;

namespace practica_7
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

        private void List_Click(object sender, RoutedEventArgs e)
        {
            Pages.LiastBoxPage liastBoxPage = new LiastBoxPage();
            frame.Navigate(liastBoxPage);
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Pages.DataGridPage liastBoxPage = new DataGridPage();
            frame.Navigate(liastBoxPage);
        }

        private void Wrap_Click(object sender, RoutedEventArgs e)
        {
            Pages.WrapPanelPage wrapPanelPage = new WrapPanelPage();
            frame.Navigate(wrapPanelPage);
        }
    }
}
