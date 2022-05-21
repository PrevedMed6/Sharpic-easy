namespace Sharpic_easy
{
    internal class Utils
    {
        internal static string CleanMessage(string message)
        {
            return message.Trim().Replace("!","").Replace("?", "").Replace(",", "").Replace(".", "");
        }
    }
}