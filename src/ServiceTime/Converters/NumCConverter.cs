using System;
using System.Linq;
using Xamarin.Forms;

namespace ServiceTime.Converters
{
	public class NumCConverter : ValueConverter<string, string>
	{
		public static readonly IValueConverter Instance = new NumCConverter();

		public NumCConverter () : base(ConvertNumC, v=>v)
		{
		}

		static string ConvertNumC(string value)
		{
			if (!string.IsNullOrWhiteSpace (value)) {
				return new string (value.ToCharArray ().SkipWhile (c=>'0'.Equals(c)).ToArray ());
			}

			return value;
		}
	}
}

