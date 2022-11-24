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
using WpfApp8.Classes;

namespace WpfApp8.Pages
{
    /// <summary>
    /// Логика взаимодействия для AllUsersPage.xaml
    /// </summary>
    public partial class AllUsersPage : Page
    {
        public ObservableCollection<User> Users { get; set; } = new ObservableCollection<User>
        {
            new User("Vasya", "User", new DateTime(2020, 10, 01)),
            new User("admin_01", "Admin", new DateTime(2019, 06, 16)),
            new User("Vova_ninja_777", "User", new DateTime(2020, 11, 11))
        };
        public User SelectedUser { get; set; }
        public AllUsersPage()
        {
            InitializeComponent();
            
            DataContext = this;
        }

        private void RemoveItem(object sender, RoutedEventArgs e)
        {
            if(SelectedUser != null) Users.Remove(SelectedUser);
        }
    }
}
