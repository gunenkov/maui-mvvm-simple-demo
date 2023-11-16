using System.Globalization;

namespace MauiApp1.Converters
{
    class TextToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == (string)parameter)
            {
                return Colors.Green;
            }
            else
            {
                return Colors.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
