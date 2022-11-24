﻿using System;
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

namespace RadioButton
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            resLable.Background = Brushes.Red;
          
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            resLable.Background = Brushes.Blue;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            resLable.Background = Brushes.Green;
        }

        //Шрифт
        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            resLable.FontWeight = FontWeights.Normal;
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            resLable.FontWeight = FontWeights.SemiBold;
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            resLable.FontWeight = FontWeights.Bold;
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            resLable.IsEnabled = true;
            GB1.IsEnabled = true;
            GB2.IsEnabled = true;
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            resLable.IsEnabled = false;
            GB1.IsEnabled = false;
            GB2.IsEnabled = false;
        }
    }
}