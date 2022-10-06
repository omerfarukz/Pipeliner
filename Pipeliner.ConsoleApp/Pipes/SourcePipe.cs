namespace Pipeliner.ConsoleApp.Pipes;

public class SourcePipe<TInput> : ISourcePipe<TInput>
{
    private Func<IAsyncEnumerable<TInput>> _func;

    public SourcePipe()
    {
        _func = () => Enumerable.Empty<TInput>().AsAsyncEnumerable();
    }

    public IAsyncEnumerable<TInput> Fetch()
    {
        return _func();
    }

    public SourcePipe<TInput> Set(Func<IEnumerable<TInput>> func)
    {
        return Set(() => func().AsAsyncEnumerable());
    }

    public SourcePipe<TInput> Set(Func<IAsyncEnumerable<TInput>> func)
    {
        _func = func ?? throw new ArgumentNullException(nameof(func));
        return this;
    }
}