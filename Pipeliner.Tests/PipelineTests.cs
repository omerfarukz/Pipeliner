using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Pipeliner.Tests;

public class PipelineTests
{
    [Fact]
    public async Task cast_source_multiple_times_by_then_extension_should_pass()
    {
        double result = 0;
        await new SourcePipe<string>()
            .Then(f => f.Split(' '))
            .Then(f => Array.ConvertAll(f, double.Parse))
            .Then(f => f.Sum())
            .Execute(
                new[] {"1 2 3"},
                f=> result = f
            );
        
        Assert.Equal(6d, result);
    }
    
    [Fact]
    public async Task convert_source_multiple_times_by_then_extension_should_pass()
    {
        var results = new List<double>();
        var combineElements = new double[] {1, 2, 3, 4, 5};
        var convertPipeline = new SourcePipe<double>()
            .Combine(
                Convert.ToString, // Convert from double to string
                Convert.ToChar, // Convert from string to char
                Convert.ToByte, // Convert from char to byte
                Convert.ToInt32 // Convert from byte to int
            );
        
        await convertPipeline.Execute(
            combineElements, // 1, 2, 3, 4, 5
            f=> results.Add(f) // 4950515253
        );
        
        Assert.Equal(49, results[0]);
        Assert.Equal(50, results[1]);
        Assert.Equal(51, results[2]);
        Assert.Equal(52, results[3]);
        Assert.Equal(53, results[4]);
    }
}