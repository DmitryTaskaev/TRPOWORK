using PRACTICA_26_10.Classes;
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
using System.IO;
using Newtonsoft.Json;

namespace PRACTICA_26_10.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
       // private User user { get; set; } = new User();

        public UserPage()
        {
            InitializeComponent();
         
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
       

        }

        private void CheckProperties_Click(object sender, RoutedEventArgs e)
        {
            string pattern = "Username: {0}; Status: {1}";
        }
        private void name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsLetter(symbol))&& e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
          
          
        }
    }
}
