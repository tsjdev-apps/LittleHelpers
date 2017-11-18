using System;
using System.Diagnostics;

namespace LittleHelpers.ExtensionMethods
{
    public static class ExceptionExtensions
    {
        /// <summary>
        ///     Logs an exception as debug output.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public static void LogDebug(this Exception exception)
        {
            Debug.WriteLine($"EXCEPTION: {exception}");
        }
    }
}