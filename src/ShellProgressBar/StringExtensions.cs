using System;
using System.Collections.Generic;
using System.Text;

namespace ShellProgressBar
{
    internal static class StringExtensions
    {
        public static string Excerpt(this string phrase, int length = 60, string truncationSuffix = "...")
        {
            if (string.IsNullOrEmpty(phrase) || phrase.Length <= length - truncationSuffix.Length)
                return phrase;
            return phrase.Substring(0, length - truncationSuffix.Length) + truncationSuffix;
        }

		public static T[] SubArray<T>(this T[] array, int offset, int length)
		{
			if (length > array.Length)
				length = array.Length;
			T[] result = new T[length];
			Array.Copy(array, offset, result, 0, length);
			return result;
		}

		public static IEnumerable<string> SplitBy(this string str, int chunkLength)
		{
			if (String.IsNullOrEmpty(str)) throw new ArgumentException();
			if (chunkLength < 1) throw new ArgumentException();

			for (int i = 0; i < str.Length; i += chunkLength)
			{
				if (chunkLength + i > str.Length)
					chunkLength = str.Length - i;

				yield return str.Substring(i, chunkLength);
			}
		}
	}
}
