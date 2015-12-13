using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;

namespace ColorfulText.Helpers
{
    public class RadioToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (targetType != typeof(Brush))
            {
                return null;
            }

            var color = (string)value;
            switch (color)
            {
                case "LimeGreen":
                    return new SolidColorBrush(Colors.LimeGreen);
                case "Aqua":
                    return new SolidColorBrush(Colors.Aqua);
                case "Coral":
                    return new SolidColorBrush(Colors.Coral);
                case "DarkOrange":
                    return new SolidColorBrush(Colors.DarkOrange);
                case "HotPink":
                    return new SolidColorBrush(Colors.HotPink);
                case "Red":
                    return new SolidColorBrush(Colors.Red);
                case "Blue":
                    return new SolidColorBrush(Colors.Blue);
                case "Green":
                    return new SolidColorBrush(Colors.Green);
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new System.NotImplementedException();
        }
    }
}
