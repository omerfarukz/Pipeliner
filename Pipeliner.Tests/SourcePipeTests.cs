using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class SourcePipeTests
{
    [Fact]
    public async Task create_new_without_set_and_fetch_should_return_empty_collection()
    {
        var pipe = new SourcePipe<int>();
        var enumerator = pipe.Fetch().GetAsyncEnumerator();
        Assert.False(await enumerator.MoveNextAsync());
    }

    [Fact]
    public async Task create_new_with_set_and_fetch_should_given_collection()
    {
        var pipe = new SourcePipe<int>();
        pipe.Set(() => new[] {1, 2});
        var enumerator = pipe.Fetch().GetAsyncEnumerator();

        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(1, enumerator.Current);
        
        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(2, enumerator.Current);
    }
    
    [Fact]
    public async Task create_new_with_multiple_set_and_fetch_should_return_given_collection()
    {
        var pipe = new SourcePipe<int>();
        pipe.Set(() => new[] {1, 2});
        pipe.Set(() => new[] {3, 4}.AsAsyncEnumerable());
        var enumerator = pipe.Fetch().GetAsyncEnumerator();

        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(3, enumerator.Current);
        
        Assert.True(await enumerator.MoveNextAsync());
        Assert.Equal(4, enumerator.Current);
    }
}