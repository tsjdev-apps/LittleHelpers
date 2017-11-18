using System;

namespace LittleHelpers.ExtensionMethods
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Converts a DateTime object to the unix timestamp.
        /// </summary>
        /// <param name="dateTime">The date time.</param>
        public static int ToUnixTimestamp(this DateTime dateTime)
        {
            return (int)Math.Truncate(dateTime.ToUniversalTime().Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
        }
    }
}
