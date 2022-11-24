using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_7.Converters
{
    using System.Runtime;
    using System.Windows;
    using System.Windows.Data;
    using System.Globalization;
    class ImagePathConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"./../Image/{value}";
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString().Substring(8);
        }
    }
}
