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

namespace Langue
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

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {
        }

        private void Lang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int item = Convert.ToInt32(Lang.SelectedIndex);

            switch (item)
            {
                case 0:
                    Name.Content = "Имя:";
                    Family.Content = "Фамилия:";
                    Phonenumber.Content = "Номер телефона:";
                    Langu.Content = "Язык:";
                    break;
                case 1:
                    Name.Content = "Name:";
                    Family.Content = "Nachname:";
                    Phonenumber.Content = "Telefonnummer:";
                    Langu.Content = "Sprache:";
                    break;
                case 2:
                    Name.Content = "Name:";
                    Family.Content = "Surname:";
                    Phonenumber.Content = "Phone number:";
                    Langu.Content = "Language:";
                    break;
            }
        }
    }
}
