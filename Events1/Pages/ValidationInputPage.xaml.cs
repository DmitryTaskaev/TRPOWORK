using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для ValidationInputPage.xaml
    /// </summary>
    public partial class ValidationInputPage : Page
    {
        public ValidationInputPage()
        {
            InitializeComponent();
        }
        private bool AllLetters(string text)
        {
            foreach (char symbol in text)
            {
                if (!char.IsLetter(symbol))
                    return false;
            }
            return true;
        }
        private void NameTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsLetter(symbol)))
            {
                e.Handled = true;
            }
        }
        private void IdTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // или самостоятельно с помощью foreach/for
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
        }
        private void IdTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void AgeTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(AgeTextBox.Text);
                if (e.Text.Any(symbol => !char.IsDigit(symbol)))
                {
                    e.Handled = true;
                }
                if (age >= 0 && age <= 10)
                {

                }
                else
                {
                    e.Handled = true;
                }
            } catch(Exception)
            {

            }
        }

        private void PhoneTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Any(symbol => !char.IsDigit(symbol)))
            {
                e.Handled = true;
            }
            if(PhoneTextBox.Text.Length == 11)
            {
                e.Handled = true;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!PhoneTextBox.Text.StartsWith("8"))
            {
                PhoneTextBox.Text = "";
            }
        }
    }
}
