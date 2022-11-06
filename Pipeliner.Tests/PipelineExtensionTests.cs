using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class PipelineExtensionTests
{
    [Fact]
    public void source_pipe_should_be_transformed()
    {
        var sourcePipe = new SourcePipe<int>();
        var intToStringTransformPipe = sourcePipe.Then(f => f.ToString());

        var collection = new List<string>();
        intToStringTransformPipe.Execute(Enumerable.Range(1, 3), collection.Add);
        
        Assert.Equal(3, collection.Count);
        Assert.Equal("1", collection[0]);
        Assert.Equal("2", collection[1]);
        Assert.Equal("3", collection[2]);
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

    [Fact]
    public void cast_transform_pipe_with_over_source_pipe_should_pass()
    {
        var collection = new List<int>();
        var sourcePipe = new SourcePipe<int>();
        sourcePipe.Set(() => Enumerable.Range(1, 3));
        var transformPipe = new TransformPipe<int, string>(f => f.ToString()).Then(int.Parse);
        transformPipe.Execute(sourcePipe, collection.Add);

        Assert.Equal(3, collection.Count);
        Assert.Equal(1, collection[0]);
        Assert.Equal(2, collection[1]);
        Assert.Equal(3, collection[2]);
    }
    
    [Fact]
    public void transform_the_transform_pipe_from_input_to_output_and_next_should_pass()
    {
        var multipleIntPipe = new TransformPipe<int, double>(f => Math.Pow(2, f));
        var intToStringPipeOverMultiplication = multipleIntPipe.Then(async f =>
        {
            await Task.Delay(0);
            return f.ToString(CultureInfo.InvariantCulture);
        });

        var collection = new List<string>();
        intToStringPipeOverMultiplication.Execute(Enumerable.Range(1, 3), collection.Add);

        Assert.Equal(3, collection.Count);
        Assert.Equal("2", collection[0]);
        Assert.Equal("4", collection[1]);
        Assert.Equal("8", collection[2]);
    }
}