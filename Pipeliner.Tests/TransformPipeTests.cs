using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class TransformPipeTests
{
    [Fact]
    public async Task source_items_should_be_multiplied_by_two()
    {
        var sourcePipe = new SourcePipe<int>();
        sourcePipe.Set(() => new[] {1, 2, 3});

        var transformPipe = new TransformPipe<int, int>(f => f * 2);
        var newSource = transformPipe.Transform(sourcePipe);

        var asyncEnumerable = newSource.Fetch();
        Assert.NotNull(asyncEnumerable);

        var enumerator = asyncEnumerable.GetAsyncEnumerator();

        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(2, enumerator.Current);
        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(4, enumerator.Current);
        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(6, enumerator.Current);
    }
    
    [Fact]
    public async Task source_items_should_be_multiplied_by_two_with_task()
    {
        var sourcePipe = new SourcePipe<int>();
        sourcePipe.Set(() => new[] {1, 2, 3});

        var transformPipe = new TransformPipe<int, int>(async f =>
        {
            await Task.Delay(0);
            return f * 2;
        });
        var newSource = transformPipe.Transform(sourcePipe);

        var asyncEnumerable = newSource.Fetch();
        Assert.NotNull(asyncEnumerable);

        var enumerator = asyncEnumerable.GetAsyncEnumerator();

        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(2, enumerator.Current);
        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(4, enumerator.Current);
        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(6, enumerator.Current);
    }
}