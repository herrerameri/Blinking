using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace Practica1.Converters
{
    public class ButtonToText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var eyeOpen = false;
            bool.TryParse(value.ToString(), out eyeOpen);
            if (eyeOpen)
            {
                return "Open";
            }
            return "Close";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}
