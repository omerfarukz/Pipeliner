namespace Pipeliner.ConsoleApp.Pipes;

public static class PipeExtensions
{
    #region SourcePipe

    public static ITransformPipe<TInput, TOutput> Then<TInput, TOutput>(
        this ISourcePipe<TInput> sourcePipe, Func<TInput, TOutput> func)
    {
        return new TransformPipe<TInput, TOutput>(func);
    }

    public static ITransformPipe<TInput, TOutput> Then<TInput, TOutput>(
        this ISourcePipe<TInput> sourcePipe, Func<TInput, Task<TOutput>> func)
    {
        return new TransformPipe<TInput, TOutput>(func);
    }
    
    #endregion

    #region ITargetPipe

    public static Task Execute<TInput>(this IEnumerable<TInput> source, Action<TInput> action)
    {
        var sourcePipe = new SourcePipe<TInput>();
        sourcePipe.Set(() => source);
        return Execute(sourcePipe, action);
    }

    public static Task Execute<TInput>(this ISourcePipe<TInput> sourcePipe, Action<TInput> action)
    {
        return new TargetPipe<TInput>(action).Execute(sourcePipe);
    }

    public static Task Execute<TInput>(this ITargetPipe<TInput> targetPipe, IEnumerable<TInput> enumerable)
    {
        var sourcePipe = new SourcePipe<TInput>();
        sourcePipe.Set(() => enumerable);
        return targetPipe.Execute(sourcePipe);
    }

    #endregion

    #region TransformPipe

    public static Task Execute<TInput, TOutput>(
        this ITransformPipe<TInput, TOutput> transformPipe,
        IEnumerable<TInput> source,
        Action<TOutput> action
    )
    {
        var sourcePipe = new SourcePipe<TInput>();
        sourcePipe.Set(() => source);

        return ExecuteInternal(transformPipe, sourcePipe, action);
    }

    public static Task Execute<TInput, TOutput>(
        this ITransformPipe<TInput, TOutput> transformPipe,
        ISourcePipe<TInput> sourcePipe,
        Action<TOutput> action
    )
    {
        return ExecuteInternal(transformPipe, sourcePipe, action);
    }

    private static Task ExecuteInternal<TInput, TOutput>(
        this ITransformPipe<TInput, TOutput> transformPipe,
        ISourcePipe<TInput> sourcePipe,
        Action<TOutput> action
    )
    {
        return transformPipe.Transform(sourcePipe).Execute(action);
    }

    public static ITransformPipe<TInput, TNext> Then<TInput, TOutput, TNext>(
        this ITransformPipe<TInput, TOutput> transformPipe,
        Func<TOutput, TNext> func
    )
    {
        return new TransformPipe<TInput, TNext>(pipe =>
        {
            var nextSource = new SourcePipe<TNext>();
            var outputSource = transformPipe.Transform(pipe);
            nextSource.Set(() => outputSource.Fetch().Map(func));
            return nextSource;
        });
    }

    public static ITransformPipe<TInput, TNext> Then<TInput, TOutput, TNext>(
        this ITransformPipe<TInput, TOutput> transformPipe,
        Func<TOutput, Task<TNext>> func
    )
    {
        return new TransformPipe<TInput, TNext>(pipe =>
        {
            var nextSource = new SourcePipe<TNext>();
            var outputSource = transformPipe.Transform(pipe);
            nextSource.Set(() => outputSource.Fetch().Map(func));
            return nextSource;
        });
    }

    #endregion
}