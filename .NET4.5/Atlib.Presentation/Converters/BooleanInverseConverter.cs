using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Atlib.Presentation.Converters
{
	[ValueConversion(typeof(Boolean), typeof(Boolean))]
	public class BooleanInverseConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return false;
			}
			Boolean b = (Boolean)value;
			return b == true ? false : true;
		}
		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
			{
				return false;
			}
			Boolean b = (Boolean)value;
			return b == true ? false : true;
		}
	}
}
