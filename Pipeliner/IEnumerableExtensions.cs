using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipeliner;

public static class EnumerableExtensions
{
    public static IAsyncEnumerable<T> AsAsyncEnumerable<T>(this IEnumerable<T> enumerable)
    {
        return new AsyncEnumerable<T>(enumerable);
    }

    public static async IAsyncEnumerable<TOutput> Map<TInput, TOutput>(this IAsyncEnumerable<TInput> enumerable,
        Func<TInput, Task<TOutput>> func)
    {
        await foreach (var item in enumerable)
        {
            yield return await func(item);
        }
    }

    public static async IAsyncEnumerable<TOutput> Map<TInput, TOutput>(this IAsyncEnumerable<TInput> enumerable,
        Func<TInput, TOutput> func)
    {
        await foreach (var item in enumerable)
        {
            yield return func(item);
        }
    }
}