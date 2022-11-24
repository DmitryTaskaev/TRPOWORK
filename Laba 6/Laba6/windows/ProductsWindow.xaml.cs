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
using System.Windows.Shapes;

namespace Laba6.windows
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    using Laba6.Classes;
    public partial class ProductsWindow : Window
    {
        private Shop shop;
        public ProductsWindow()
        {
            InitializeComponent();
            DataContext = shop = new Shop("Мечи & топоры");

            shop.Products.AddRange(new Product[]
            {
                new Product {ProductName = "Топорик", Count = 2, Discount = 0, Price = 6000},
                new Product {ProductName = "Томогавк", Count = 3, Discount = 0.5, Price = 4000}

            }) ;
        }
    }
}
