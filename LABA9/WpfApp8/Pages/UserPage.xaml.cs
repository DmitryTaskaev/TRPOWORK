using System;
using System.IO;
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
using WpfApp8.Classes;
using Newtonsoft.Json;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private User User { get; set; } = new User("Vasya", "Manager", new DateTime(2007, 07, 07));
        public UserPage()
        {
            InitializeComponent();
            getJson();
            DataContext = User;
        }
        private void getJson()
        {
            StreamReader sr = File.OpenText("user.json");
            User = JsonConvert.DeserializeObject<User>(sr.ReadToEnd());
            sr.Close();
        }

        private void ChangePropertiesButton(object sender, RoutedEventArgs e)
        {
            User.Username = "Natashya";
            User.Status = "Admin";
            User.LastLogin = DateTime.Now;
        }

        private void CheckPropertiesButton(object sender, RoutedEventArgs e)
        {
            string pattern = "Username {0}; Status {1}";
            MessageBox.Show(string.Format(pattern, User.Username, User.Status));
        }

        private void SavePropertiesButton(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = File.CreateText("user.json");
            string json = JsonConvert.SerializeObject(User, Formatting.Indented);
            sw.WriteLine(json);
            sw.Close();
        }

        private void Name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => char.IsLetter(symbol) || char.IsDigit(symbol) || char.IsWhiteSpace(symbol))) { }
            else { e.Handled = true; }
        }

        private void Status_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => char.IsLetter(symbol) || char.IsDigit(symbol) || char.IsWhiteSpace(symbol))) { }
            else { e.Handled = true; }
        }
    }
}
