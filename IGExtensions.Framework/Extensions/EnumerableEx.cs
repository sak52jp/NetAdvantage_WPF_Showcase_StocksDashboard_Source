//using System.Collections.Generic;

namespace System.Collections.Generic //System.Linq
{
    public static class EnumerableEx
    {
        public static IEnumerable<T> Reverse<T>(this IList<T> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                yield return list[i];
            }

            //var newList = new List<T>();
            //for (int i = list.Count - 1; i >= 0; i--)
            //{
            //    newList.Add(list[i]);
            //}
            //return newList;
        }
        /// <summary>
        /// Performs the specified action on each object in the collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="values">The collection.</param>
        /// <param name="action">The action to perform.</param>
        /// <returns></returns>
        /// <remarks>This is an extension method provided by <seealso cref="EnumerableEx"/></remarks>
        public static IEnumerable<T> Each<T>(this IEnumerable<T> values, Action<T> action)
        {
            foreach (var o in values)
            {
                action(o);
            }

            return values;
        }
        //public static int Count<T>(this IEnumerable<T> source)
        //{
        //    var c = source as ICollection<T>;
        //    if (c != null)
        //        return c.Count;

        //    var collection = source as ICollection;
        //    if (collection != null)
        //    {
        //        return collection.Count;
        //    }

        //    int result = 0;
        //    using (IEnumerator<T> enumerator = source.GetEnumerator())
        //    {
        //        while (enumerator.MoveNext())
        //            result++;
        //    }
        //    return result;
        //}
    }
}
namespace System.Collections //.Generic //System.Linq
{
    public static class EnumerableEx
    {
        public static int Count(this IEnumerable source)
        {
            var collection = source as ICollection;
            if (collection != null)
            {
                return collection.Count;
            }
            int result = 0;
            var enumerator = source.GetEnumerator();
            while (enumerator.MoveNext())
                result++;

            //using (IEnumerator enumerator = source.GetEnumerator())
            //{
            //    while (enumerator.MoveNext())
            //        result++;
            //}
            return result;
        }
    }
}