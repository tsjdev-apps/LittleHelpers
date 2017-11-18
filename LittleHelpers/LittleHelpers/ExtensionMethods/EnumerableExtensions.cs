using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LittleHelpers.ExtensionMethods
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Picks randomly an element of a list.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        /// <summary>
        /// Picks randomly a specified amount of elements of a list.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        /// <summary>
        /// Shuffles the specified source.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }

        /// <summary>
        /// Converts an <c>IEnumerable</c> to an observable collection.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
        {
            return source == null ? new ObservableCollection<T>() : new ObservableCollection<T>(source);
        }

        /// <summary>
        /// Determines whether this instance has items.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        public static bool HasItems<T>(this IEnumerable<T> source)
        {
            return source.IsNotNull() && source.Any();
        }

        /// <summary>
        /// Determines whether this instance is emtpy.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        public static bool IsEmtpy<T>(this IEnumerable<T> source)
        {
            return source.IsNotNull() && !source.Any();
        }

        /// <summary>
        /// Determines whether the <c>IEnumerable</c> [is null or emtpy].
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        public static bool IsNullOrEmtpy<T>(this IEnumerable<T> source)
        {
            if (source.IsNull())
                return true;

            return !source.Any();
        }

        /// <summary>
        /// Calls the provided action on each element in the <c>IEnumerable</c>.
        /// </summary>
        /// <typeparam name="T">The type.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="action">The action.</param>
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }

        /// <summary>
        /// Adds a range to a list.
        /// </summary>
        /// <typeparam name="T">The type</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="collection">The collection.</param>
        public static void AddRange<T>(this IList<T> source, IEnumerable<T> collection)
        {
            foreach (var item in collection)
                source.Add(item);
        }
    }
}
