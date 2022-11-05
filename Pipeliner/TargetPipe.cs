using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pipeliner;

public class TargetPipe<T> : ITargetPipe<T>
{
    private readonly Func<IAsyncEnumerable<T>, Task> _func;

    public TargetPipe(Func<IAsyncEnumerable<T>, Task> task)
    {
        _func = task ?? throw new ArgumentNullException(nameof(task));
    }

    public TargetPipe(Action<T> action)
    {
        _func = async f =>
        {
            await foreach (var item in f)
            {
                action(item);
            }
        };
    }

    public Task Execute(ISourcePipe<T> source)
    {
        return _func(source.Fetch());
    }
}