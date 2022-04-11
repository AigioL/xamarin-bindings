// ReSharper disable once CheckNamespace
namespace System
{
    public static partial class StringExtensions
    {
        public static string TrimStart(this string s, string trimString)
        {
            if (trimString.StartsWith(trimString))
            {
                return s[trimString.Length..];
            }
            else
            {
                return s;
            }
        }
    }
}