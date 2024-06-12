using System.Text.RegularExpressions;
using System.Text;

namespace Catalog.API.Infrastructure.Helpers
{
    public static class StringHelper
    {
        public static string Slugify(this string phrase)
        {
            string str = RemoveAccent(phrase).ToLower();
            // Remove invalid characters
            str = Regex.Replace(str, @"[^a-z0-9\s-]", "");
            // Convert multiple spaces into one space
            str = Regex.Replace(str, @"\s+", " ").Trim();
            // Replace spaces with hyphens
            str = Regex.Replace(str, @"\s", "-");
            return str;
        }

        private static string RemoveAccent(string txt)
        {
            byte[] bytes = Encoding.GetEncoding("Cyrillic").GetBytes(txt);
            return Encoding.ASCII.GetString(bytes);
        }
    }
}
