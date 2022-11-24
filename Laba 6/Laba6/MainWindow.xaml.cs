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

namespace Laba6
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

        private void ElementsBinding_Click(object sender, RoutedEventArgs e)
        {
            windows.ElementsBindingWindows el = new windows.ElementsBindingWindows();
            el.ShowDialog();
        }

        private void Resourse_Click(object sender, RoutedEventArgs e)
        {
            windows.ResourseBindingWindows r = new windows.ResourseBindingWindows();
            r.ShowDialog();
        }

        private void Products_Click(object sender, RoutedEventArgs e)
        {
            windows.ProductsWindow p = new windows.ProductsWindow();
            p.ShowDialog();
        }
    }
}
