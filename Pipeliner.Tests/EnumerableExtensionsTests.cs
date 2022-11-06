using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class EnumerableExtensionsTests
{
    [Fact]
    public async void cast_enumerable_to_async_enumerable_should_pass()
    {
        var enumerable = Enumerable.Range(1, 10);
        var asyncEnumerable = enumerable.AsAsyncEnumerable();
        Assert.NotNull(asyncEnumerable);

        var enumerator = asyncEnumerable.GetAsyncEnumerator();
        Assert.NotNull(enumerator);

        await enumerator.DisposeAsync();
    }

    [Fact]
    public async void create_async_enumerable_with_func_should_pass()
    {
        var enumerable = Enumerable.Range(1, 10);
        var asyncEnumerable = enumerable.AsAsyncEnumerable();
        Assert.NotNull(asyncEnumerable);

        var mappedAsyncEnumerable = asyncEnumerable.Map(f => f.ToString());
        Assert.NotNull(mappedAsyncEnumerable);

        var enumerator = mappedAsyncEnumerable.GetAsyncEnumerator();
        Assert.NotNull(enumerator);

        await enumerator.DisposeAsync();
    }

    [Fact]
    public async void create_async_enumerable_with_func_task_should_pass()
    {
        var enumerable = Enumerable.Range(1, 10);
        var asyncEnumerable = enumerable.AsAsyncEnumerable();
        Assert.NotNull(asyncEnumerable);

        var mappedAsyncEnumerable = asyncEnumerable.Map(Task.FromResult);
        Assert.NotNull(mappedAsyncEnumerable);

        var enumerator = mappedAsyncEnumerable.GetAsyncEnumerator();
        Assert.NotNull(enumerator);

        await enumerator.DisposeAsync();
    }

    [Fact]
    public async void create_empty_async_enumerable_should_be_mapped_as_empty()
    {
        var enumerable = Enumerable.Empty<int>();
        var asyncEnumerable = enumerable.AsAsyncEnumerable();
        var mapped = asyncEnumerable.Map(f => f);
        Assert.NotNull(mapped);
        var mappedEnumerator = mapped.GetAsyncEnumerator();
        Assert.False(await mappedEnumerator.MoveNextAsync());
    }
    
    [Fact]
    public async void create_empty_async_enumerable_should_be_mapped_to_task_as_empty()
    {
        var enumerable = Enumerable.Empty<int>();
        var asyncEnumerable = enumerable.AsAsyncEnumerable();
        var mapped = asyncEnumerable.Map(f => Task.FromResult(0));
        Assert.NotNull(mapped);
        var mappedEnumerator = mapped.GetAsyncEnumerator();
        Assert.False(await mappedEnumerator.MoveNextAsync());
    }
}