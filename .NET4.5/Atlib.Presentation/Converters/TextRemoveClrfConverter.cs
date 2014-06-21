using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;

namespace Atlib.Presentation.Converters
{
	[ValueConversion(typeof(String), typeof(String))]
	public class TextRemoveClrfConverter : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value.ToString().Replace(Environment.NewLine, "");
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value.ToString().Replace(Environment.NewLine, "");
		}
	}
}
