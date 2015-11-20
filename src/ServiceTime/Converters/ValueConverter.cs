using System;
using Xamarin.Forms;
using System.Globalization;

namespace ServiceTime.Converters
{
	public class ValueConverter<TSource, TTarget> : IValueConverter
	{
		private readonly Func<TSource, object, CultureInfo, TTarget> _convert;
		private readonly Func<TTarget, object, CultureInfo, TSource> _convertBack;

		private static readonly Func<TTarget, object, CultureInfo, TSource> _emptyConvertBack = null;

		public ValueConverter(Func<TSource, object, CultureInfo, TTarget> convert, Func<TTarget, object, CultureInfo, TSource> convertBack = null)
		{
			Guard.NotNull (() => convert, convert);

			_convert = convert;
			_convertBack = convertBack;
		}

		public ValueConverter(Func<TSource, object, TTarget> convert, Func<TTarget, object, TSource> convertBack = null) : this(
			(v, p, c) => convert(v, p), null != convertBack ? (v, p, c) => convertBack(v,p) : _emptyConvertBack)
		{
		}

		public ValueConverter(Func<TSource, TTarget> convert, Func<TTarget, TSource> convertBack = null) : this(
			(v, p, c) => convert(v), null != convertBack ? (v, p, c) => convertBack(v) : _emptyConvertBack)
		{
		}

		#region IValueConverter implementation

		object IValueConverter.Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return Convert ((TSource)value, parameter, culture);
		}

		object IValueConverter.ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return ConvertBack ((TTarget)value, parameter, culture);
		}

		#endregion

		protected virtual TTarget Convert(TSource value, object parameter, System.Globalization.CultureInfo culture)
		{
			return _convert (value, parameter, culture);
		}

		protected virtual TSource ConvertBack(TTarget value, object parameter, CultureInfo culture)
		{
			if (null == _convertBack) {
				throw new NotSupportedException ();
			}

			return _convertBack (value, parameter, culture);
		}
	}
}

