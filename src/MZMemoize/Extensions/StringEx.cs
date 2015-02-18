using System;

namespace MZMemoize.Extensions
{
    public static class StringEx
    {
        /// <summary>
        /// Case insensitive string contains.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="subString"></param>
        /// <returns></returns>
        public static bool ContainsEx(this string value, string subString)
        {
            return value.ContainsEx(subString, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Returns a value indicating whether the specified System.String object occurs within this string.
        /// </summary>
        /// <param name="value">this string</param>
        /// <param name="subString">subString to find in this string</param>
        /// <param name="comparison">comparison to use when looking for the sub-string</param>
        /// <returns>true if the specified subString occurs within this string.</returns>
        public static bool ContainsEx(this string value, string subString, StringComparison comparison)
        {
            if (!subString.HasValue())
                return false;
            return value.EmptyIfNull().IndexOf(subString, comparison) >= 0;
        }

        /// <summary>
        /// Case insensitive string comparison
        /// </summary>
        public static bool EqualsEx(this string value, string compareTo)
        {
            return value.Equals(compareTo, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Returns string.Empty if this string is null
        /// </summary>
        /// <param name="value">this string</param>
        /// <returns>given value if not null, otherwise ""</returns>
        public static string EmptyIfNull(this string value)
        {
            return value ?? String.Empty;
        }

        /// <summary>
        /// Same as String.IsNullOrEmpty(s) but nicer notation.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool HasValue(this string s)
        {
            return !String.IsNullOrEmpty(s);
        }
    }
}
