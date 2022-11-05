using System.Collections.Generic;

namespace Pipeliner;

public interface ISourcePipe<out TOutput>
{
    IAsyncEnumerable<TOutput> Fetch();
}