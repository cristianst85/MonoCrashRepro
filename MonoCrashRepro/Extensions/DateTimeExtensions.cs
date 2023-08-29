using System;
using TimeZoneNames;

namespace MonoCrashRepro.Extensions
{
    public static class DateTimeExtensions
    {
        public static string GetCurrentTimeZoneAbbreviation(this DateTime dateTime, string languageCode)
        {
            var currentTimeZone = TimeZone.CurrentTimeZone;
            var timeZoneValues = TZNames.GetAbbreviationsForTimeZone(currentTimeZone.StandardName, languageCode);

            return currentTimeZone.IsDaylightSavingTime(dateTime) ? timeZoneValues.Daylight : timeZoneValues.Standard;
        }
    }
}
