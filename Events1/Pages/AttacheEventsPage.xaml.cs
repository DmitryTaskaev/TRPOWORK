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
    /// Логика взаимодействия для AttacheEventsPage.xaml
    /// </summary>
    public partial class AttacheEventsPage : Page
    {
        public AttacheEventsPage()
        {
            InitializeComponent();
        }
        private void TextComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var Item = TextComboBox.SelectedItem as ComboBoxItem;
            if (Item != null)
            {
                TextBlockBottom.Text += Item.Content.ToString() + "\n";
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var Selected = e.Source as RadioButton;
            TextBlockTop.Text += Selected.Content.ToString() + "\n";
        }

    }
}
