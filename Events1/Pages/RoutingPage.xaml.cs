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

namespace Events1.Pages
{
    /// <summary>
    /// Логика взаимодействия для RoutingPage.xaml
    /// </summary>
    public partial class RoutingPage : Page
    {
        public RoutingPage()
        {
            InitializeComponent();
        }
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlockTop.Text += "Вызвано элементом: " + sender.ToString() + "\n";
            TextBlockTop.Text += "Источник события: " + e.Source.ToString() + "\n\n";
        }
        private void Control_MouseDownPreview(object sender, MouseButtonEventArgs e)
        {
            TextBlockBottom.Text += "Вызвано элементом: " + sender.ToString() + "\n";
            TextBlockBottom.Text += "Источник события: " + e.Source.ToString() + "\n\n";
        }


    }
}
