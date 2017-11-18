namespace LittleHelpers.ExtensionMethods
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Determines whether the object is not null.
        /// </summary>
        /// <param name="obj">The object.</param>
        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }
        
        /// <summary>
        /// Determines whether the object is null.
        /// </summary>
        /// <param name="obj">The object.</param>
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        /// <summary>
        /// Returns every object as string.
        /// </summary>
        /// <param name="obj">The object.</param>
        public static string AsString(this object obj)
        {
            return obj == null ? string.Empty : obj.ToString();
        }
    }
}
