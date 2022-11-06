using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Pipeliner;

public class AsyncEnumerable<T> : IAsyncEnumerable<T>
{
    private readonly AsyncEnumerator _enumerator;

    public AsyncEnumerable(IEnumerable<T> enumerable)
    {
        _enumerator = new AsyncEnumerator(enumerable);
    }

    public async IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = new())
    {
        while (await _enumerator.MoveNextAsync())
        {
            yield return _enumerator.Current;
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