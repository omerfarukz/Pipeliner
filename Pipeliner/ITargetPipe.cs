using System.Threading.Tasks;

namespace Pipeliner;

public interface ITargetPipe<in TInput>
{
    Task Execute(ISourcePipe<TInput> source);
}