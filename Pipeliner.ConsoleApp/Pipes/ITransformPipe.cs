namespace Pipeliner.ConsoleApp.Pipes;

public interface ITransformPipe<TInput, TOutput>
{
    ISourcePipe<TOutput> Transform(ISourcePipe<TInput> sourcePipe);
}