namespace Pipeliner.ConsoleApp.Pipes;

public class TransformPipe<TInput, TOutput> : ITransformPipe<TInput, TOutput>
{
    private readonly Func<ISourcePipe<TInput>, ISourcePipe<TOutput>> _func;

    public TransformPipe(Func<ISourcePipe<TInput>, ISourcePipe<TOutput>> func)
    {
        _func = func ?? throw new ArgumentNullException(nameof(func));
    }

    public TransformPipe(Func<TInput, TOutput> func)
    {
        _func = sourcePipe =>
        {
            var newSourcePipe = new SourcePipe<TOutput>();
            newSourcePipe.Set(() => sourcePipe.Fetch().Map(func));
            return newSourcePipe;
        };
    }
    
    public TransformPipe(Func<TInput, Task<TOutput>> func)
    {
        _func = sourcePipe =>
        {
            var newSourcePipe = new SourcePipe<TOutput>();
            newSourcePipe.Set(() => sourcePipe.Fetch().Map(func));
            return newSourcePipe;
        };
    }

    public ISourcePipe<TOutput> Transform(ISourcePipe<TInput> sourcePipe)
    {
        return _func(sourcePipe);
    }
}