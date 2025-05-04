using System.Text.RegularExpressions;

namespace Jcf.AM.Control.Api.Extensions
{
    public static class StringExtension
    {
        public static string OnlyNumbers(this string? str)
        {
            if (str == null) return string.Empty;
            return Regex.Replace(str, "[^0-9]", "");
        }

        public static string FirstPart(this string str)
        {
            if (str == null) return string.Empty;
            string[] parts = str.Split(' ');
            return parts[0];
        }

        public static bool Min(this string str, int min = 3)
        {
            return str.Length >= (min < 0 ? 0 : min);
        }

        public static bool Max(this string str, int max = 256)
        {
            return str.Length <= (max < 0 ? 256 : max);
        }
    }
}
