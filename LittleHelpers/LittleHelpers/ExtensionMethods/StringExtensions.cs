namespace LittleHelpers.ExtensionMethods
{
    public static class StringExtensions
    {
        /// <summary>
        ///     Determines whether the string is neither null nor empty.
        /// </summary>
        /// <param name="str">The string.</param>
        public static bool IsNeitherNullNorEmpty(this string str)
        {
            return !string.IsNullOrEmpty(str);
        }

        /// <summary>
        ///     Determines whether the string is null or empty.
        /// </summary>
        /// <param name="str">Ths string.</param>
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
    }
}