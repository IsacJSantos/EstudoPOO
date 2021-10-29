using System.Globalization;

namespace System
{
    static class DateTimeExtensios
    {
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if (duration.TotalSeconds < 60)
                return duration.TotalSeconds.ToString("F1", CultureInfo.InvariantCulture) + " seconds";
            else if (duration.TotalMinutes < 60)
                return duration.TotalMinutes.ToString("F1", CultureInfo.InvariantCulture) + " minutes";
            else if (duration.TotalHours < 24)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            else
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";

        }
    }
}
