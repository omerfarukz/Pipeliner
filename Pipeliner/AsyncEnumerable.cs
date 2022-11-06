using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Pipeliner;

public class AsyncEnumerable<T> : IAsyncEnumerable<T>
{
    private readonly IEnumerable<T> _enumerable;

    public AsyncEnumerable(IEnumerable<T> enumerable)
    {
        _enumerable = enumerable;
    }

    public async IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = new())
    {
        await using var enumerator = new AsyncEnumerator(_enumerable);
        while (await enumerator.MoveNextAsync())
        {
            yield return enumerator.Current;
        }
    }

    private sealed class AsyncEnumerator : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _enumerator;

        public AsyncEnumerator(IEnumerable<T> enumerable)
        {
            _enumerator = enumerable.GetEnumerator();
        }

        public ValueTask DisposeAsync()
        {
            return new ValueTask(Task.CompletedTask);
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(_enumerator.MoveNext());
        }

        public T Current => _enumerator.Current;
    }
}