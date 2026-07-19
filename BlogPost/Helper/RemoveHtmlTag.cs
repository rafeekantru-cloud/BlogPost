using System.Text.RegularExpressions;

namespace BlogPost.Helper
{
    public class RemoveHtmlTag
    {
        public static string RemoveHtmlTags(string input)
        {
            return Regex.Replace(input, "<.*?>|&.*?;", string.Empty); // This removes any HTML tags.
        }
    }
}
