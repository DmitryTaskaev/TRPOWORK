using PRACTICA_26_10.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PRACTICA_26_10.Pages
{
    /// <summary>
    /// Логика взаимодействия для AllUsersPage.xaml
    /// </summary>
    public partial class AllUsersPage : Page
    {
        public ObservableCollection<User> User { get; set; } = new ObservableCollection<User>
        {
            new User("GHghfhf", "User", new DateTime(2022,01,01)),
            new User("GHghfhf", "User", new DateTime(2022,01,01)),
            new User("GHghfhf", "User", new DateTime(2022,01,01))
        };

        public User SelectedUser { get; set; }
        public AllUsersPage()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(SelectedUser != null)
            {
                User.Remove(SelectedUser);
            }
        }
    }
}
