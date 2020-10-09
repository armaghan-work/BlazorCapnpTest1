
namespace Services.Share
{
    public static class StringHelperService
    {
        public static string RemoveQuotation(this string str)
        {
            return str.Replace("\"", "");
        }
    }
}
