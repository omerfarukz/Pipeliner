using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class PipelineExtensionTests
{
    [Fact]
    public void test()
    {
        var sourcePipe = new SourcePipe<int>();
        var intToStringTransformPipe = sourcePipe.Then(f=> f.ToString());


        intToStringTransformPipe.Execute(Enumerable.Range(0, 10), Console.Write);
    }

    [Fact]
    public void ordinary_enumerable_should_be_executed()
    {
        var collection = new List<int>();
        Enumerable.Range(1, 3).Execute(f => collection.Add(f));
        Assert.Equal(3, collection.Count);
        Assert.Equal(1, collection[0]);
        Assert.Equal(2, collection[1]);
        Assert.Equal(3, collection[2]);
    }
    
    [Fact]
    public void target_pipe_should_be_executed_with_enumerable()
    {
        var collection = new List<int>();
        var targetPipe = new TargetPipe<int>(f => collection.Add(f));

        targetPipe.Execute(Enumerable.Range(1, 3));
        
        Assert.Equal(3, collection.Count);
        Assert.Equal(1, collection[0]);
        Assert.Equal(2, collection[1]);
        Assert.Equal(3, collection[2]);
    }
    
    [Fact]
    public void cast_transform_pipe_should_pass()
    {
        var collection = new List<int>();
        var transformPipe = new TransformPipe<int, string>(f => f.ToString()).Then(int.Parse);
        transformPipe.Execute(Enumerable.Range(1, 3), collection.Add);
        
        Assert.Equal(3, collection.Count);
        Assert.Equal(1, collection[0]);
        Assert.Equal(2, collection[1]);
        Assert.Equal(3, collection[2]);
    }
}