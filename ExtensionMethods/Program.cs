using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var test = new List<int>();
            //var test = new List<int>() { 1 };
            //var test = new List<int>() { 1, 2 };
            var test = new List<int>() { 1, 2, 3 };

            var result = test.SelectByState(e => e - 1, e => e, e => e + 1).ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }

    public static class Extensions
    {
        public static IEnumerable<TResult> SelectByState<TSource, TResult>(this IEnumerable<TSource> source,
            Func<TSource, TResult> asFirst, Func<TSource, TResult> asMiddle, Func<TSource, TResult> asLast)
        {
            var enumerator = source.GetEnumerator();
            if (enumerator.MoveNext())
            {
                yield return asFirst(enumerator.Current);
                if (enumerator.MoveNext())
                {
                    TSource prev = enumerator.Current;
                    while (enumerator.MoveNext())
                    {
                        yield return asMiddle(prev);
                        prev = enumerator.Current;
                    }
                    yield return asLast(prev);
                }
            }
        }

        public static void ExecuteByState<TSource>(this IEnumerable<TSource> source,
            Action<TSource> asFirst, Action<TSource> asMiddle, Action<TSource> asLast)
        {
            var enumerator = source.GetEnumerator();
            if (enumerator.MoveNext())
            {
                asFirst(enumerator.Current);
                if (enumerator.MoveNext())
                {
                    TSource prev = enumerator.Current;
                    while (enumerator.MoveNext())
                    {
                        asMiddle(prev);
                        prev = enumerator.Current;
                    }
                    asLast(prev);
                }
            }
        }
    }
}
