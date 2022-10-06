namespace Pipeliner.ConsoleApp.Pipes;

public interface ISourcePipe<TOutput>
{
    IAsyncEnumerable<TOutput> Fetch();
}