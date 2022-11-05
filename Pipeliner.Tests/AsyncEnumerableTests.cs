using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class AsyncEnumerableTests
{
    [Fact]
    public async Task create_and_enumerate_first_should_pass()
    {
        int start = 1, count = 3;
        var enumerable = new AsyncEnumerable<int>(Enumerable.Range(start, count));
        var enumerator = enumerable.GetAsyncEnumerator();
        Assert.NotNull(enumerator);
        for (int i = start; i < count; i++)
        {
            Assert.True(await enumerator.MoveNextAsync());
            Assert.Equal(i, enumerator.Current);
        }

        ValueTask valueTask = enumerator.DisposeAsync();
        Assert.True(valueTask.IsCompleted);
    }
}