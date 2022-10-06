namespace Pipeliner.ConsoleApp.Pipes;

public interface ITargetPipe<TInput>
{
    Task Execute(ISourcePipe<TInput> source);
}