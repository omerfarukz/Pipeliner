namespace Pipeliner;

public interface ITransformPipe<in TInput, out TOutput>
{
    ISourcePipe<TOutput> Transform(ISourcePipe<TInput> sourcePipe);
}