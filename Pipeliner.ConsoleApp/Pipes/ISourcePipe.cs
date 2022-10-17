namespace Pipeliner.ConsoleApp.Pipes;

public interface ISourcePipe<out TOutput>
{
    IAsyncEnumerable<TOutput> Fetch();
}