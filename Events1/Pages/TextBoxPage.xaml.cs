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
    /// Логика взаимодействия для TextBoxPage.xaml
    /// </summary>
    public partial class TextBoxPage : Page
    {
        public TextBoxPage()
        {
            InitializeComponent();
        }
        private void EventsTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            OutputTextBlock.Text += "PreviewTextInput\n";
            if (ShowPropertiesCheckBox.IsChecked == true)
            {
                OutputTextBlock.Text += $"Text: {e.Text}\n";
                OutputTextBlock.Text += $"Device: {e.Device}\n";
                OutputTextBlock.Text += $"Handled: {e.Handled}\n";
                //OutputTextBlock.Text += $"Key (ToString): {e.Key}\n";
                //OutputTextBlock.Text += $"Key (Приведение к int): {(int)e.Key}\n";
            }

        }
        private void EventsTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            OutputTextBlock.Text += "PreviewKeyDown\n";
        }
        private void EventsTextBox_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            OutputTextBlock.Text += "PreviewKeyUp\n";
        }

    }
}
