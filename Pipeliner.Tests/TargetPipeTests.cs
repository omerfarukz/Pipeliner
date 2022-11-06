using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class TargetPipeTests
{
    [Fact]
    public async Task create_collection_target_should_collect_all()
    {
        var collection = new List<int>();
        var action = new Action<int>(collection.Add);

        var source = new SourcePipe<int>();
        source.Set(()=> new[] {1, 2, 3});
        var pipe = new TargetPipe<int>(action);
        await pipe.Execute(source);

        Assert.Equal(3, collection.Count);
        Assert.Equal(1, collection[0]);
        Assert.Equal(2, collection[1]);
        Assert.Equal(3, collection[2]);
    }
    
    [Fact]
    public async Task create_async_enumerable_collection_target_should_collect_all()
    {
        var collection = new List<int>();
        var source = new SourcePipe<int>();
        source.Set(()=> new[] {1, 2, 3});

        var pipe = new TargetPipe<int>(async f =>
        {
            await foreach (var item in f)
                collection.Add(item);
        });
        await pipe.Execute(source);

        Assert.Equal(3, collection.Count);
        Assert.Equal(1, collection[0]);
        Assert.Equal(2, collection[1]);
        Assert.Equal(3, collection[2]);
    }
}