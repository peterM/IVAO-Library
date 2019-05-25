using System;
using System.Globalization;

namespace MalikP.IVAO.Library.Common
{
    public static class IvaoStringExtensions
    {
        public const string IvaoDateTimeFormat = "yyyyMMddHHmmss";

        public static DateTime? IVAO_GetDateTime(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return null;
            }

            return DateTime.ParseExact(value, IvaoDateTimeFormat, CultureInfo.InvariantCulture);
        }

        public static int IVAO_GetInt(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return -1;
            }

            return int.Parse(value);
        }

        public static decimal IVAO_GetDecimal(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return -1;
            }

            return decimal.Parse(value);
        }
    }
}
