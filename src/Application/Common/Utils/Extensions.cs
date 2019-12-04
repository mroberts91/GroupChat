using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Application.Common.Utils
{
    public static class Extensions
    {
        /// <summary>
        /// Performs a IEnumerable<T>.Any() check but also returns false
        /// if the IEnumerable<T> is null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns>True/False</returns>
        public static bool HasItems<T>(this IEnumerable<T> source)
        {
            return (source?.Any() ?? false);
        }

        /// <summary>
        /// Performs a List<T>.Any() check but also returns false
        /// if the List<T> is null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns>True/False</returns>
        public static bool HasItems<T>(this List<T> source)
        {
            return (source?.Any() ?? false);
        }

        public static T GetServiceInstance<T>(this IServiceProvider provider)
        {
            return (T)provider.GetService(typeof(T));
        }

        public static T GetRequiredServiceInstance<T>(this IServiceProvider provider)
        {
            return (T)provider.GetRequiredService(typeof(T));
        }
    }
}
