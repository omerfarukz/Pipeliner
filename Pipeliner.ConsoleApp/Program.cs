using System.Text.RegularExpressions;
using Pipeliner.ConsoleApp.Pipes;

/*
 * Example 1
 */
await new SourcePipe<string>()
    .Then(f => f.Split(' '))
    .Then(f => Array.ConvertAll(f, double.Parse))
    .Then(f => f.Sum())
    .Execute(
        new[] {"1 2 3"}, 
        Console.WriteLine       // 6
    );

/*
 * Example 2
 */
var combineElements = new double[] {1, 2, 3, 4, 5};
var convertPipeline = new SourcePipe<double>()
    .Combine(
        Convert.ToString,   // Convert from double to string
        Convert.ToChar,     // Convert from string to char
        Convert.ToByte,     // Convert from char to byte
        Convert.ToInt32     // Convert from byte to int
    );

await convertPipeline.Execute(
    combineElements,    // 1, 2, 3, 4, 5
    Console.Write       // 4950515253
);

/*
 * Example 3
 */
var extractWordsPipe = new SourcePipe<Uri>()
    .Then(new HttpClient().GetAsync)
    .Then(f => f.Content.ReadAsStringAsync())
    .Then(f => Regex.Split(f, @" ([a-z]+) ").GroupBy(u => u.Trim()))
    .Then(f => f.Select(x => new {Word = x.Key, Count = x.Count()}))
    .Then(f => f.OrderByDescending(f => f.Count).Take(3))
    .Then(f => f.Select(f => f.Word))
    .Then(f => string.Join(',', f));

var uris = new[]
{
    new Uri("https://cdnjs.cloudflare.com/ajax/libs/react/18.2.0/umd/react.profiling.min.js"),
    new Uri("https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js")
};

await extractWordsPipe.Execute(uris, Console.WriteLine);