using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace LittleHelpers.Helpers
{
    public static class EnumHelper
    {
        /// <summary>
        /// Gets the default value of an <c>enum</c>.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns></returns>
        public static T GetEnumDefault<T>()
        {
            var fields = typeof(T).GetRuntimeFields();
            var defaultValue = fields.FirstOrDefault(x => x.GetCustomAttribute(typeof(DefaultValueAttribute)) != null);
            if (defaultValue == null)
                return default(T);

            return (T)Enum.Parse(typeof(T), defaultValue.Name);
        }

        /// <summary>
        /// Gets the enum as enumarable.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns></returns>
        public static IEnumerable<T> GetEnumAsEnumarable<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}
