using System;
using System.Diagnostics;
using System.Linq.Expressions;


// CITE: https://code.google.com/p/moq/source/browse/trunk/Source/Guard.cs
[DebuggerStepThrough]
internal static class Guard
{
	/// <summary>
	///     Ensures the given <paramref name="value" /> is not null.
	///     Throws <see cref="ArgumentNullException" /> otherwise.
	/// </summary>
	public static void NotNull<T>(Expression<Func<T>> reference, T value)
	{
		if (value == null)
		{
			throw new ArgumentNullException(GetParameterName(reference));
		}
	}

	/// <summary>
	///     Ensures the given string <paramref name="value" /> is not null or empty.
	///     Throws <see cref="ArgumentNullException" /> in the first case, or
	///     <see cref="ArgumentException" /> in the latter.
	/// </summary>
	public static void NotNullOrEmpty(Expression<Func<string>> reference, string value)
	{
		NotNull(reference, value);
		if (value.Length == 0)
		{
			throw new ArgumentException("Argument cannot be NotNullOrEmpty", GetParameterName(reference));
		}
	}

	private static string GetParameterName(LambdaExpression reference)
	{
		var member = (MemberExpression) reference.Body;
		return member.Member.Name;
	}
}

