namespace Pipeliner.ConsoleApp.Pipes;

public class AsyncEnumerable<T> : IAsyncEnumerable<T>
{
    private readonly AsyncEnumerator _enumator;

    public AsyncEnumerable(IEnumerable<T> enumerable)
    {
        _enumator = new AsyncEnumerator(enumerable);
    }

    public async IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = new())
    {
        while (await _enumator.MoveNextAsync())
        {
            yield return _enumator.Current;
        }
    }

    public class AsyncEnumerator : IAsyncEnumerator<T>
    {
        private readonly IEnumerator<T> _enumerator;

        public AsyncEnumerator(IEnumerable<T> enumerable)
        {
            if (enumerable == null)
                throw new ArgumentNullException(nameof(enumerable));

            _enumerator = enumerable.GetEnumerator();
        }

        public ValueTask DisposeAsync()
        {
            return ValueTask.CompletedTask;
        }

        public ValueTask<bool> MoveNextAsync()
        {
            return ValueTask.FromResult(_enumerator.MoveNext());
        }

        public T Current => _enumerator.Current;
    }
}