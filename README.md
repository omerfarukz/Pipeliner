# Pipeliner
Experimental pipeline builder

[![CI & CD](https://github.com/omerfarukz/Pipeliner/actions/workflows/CI&CD.yml/badge.svg)](https://github.com/omerfarukz/Pipeliner/actions/workflows/CI&CD.yml)

[![license](https://img.shields.io/github/license/omerfarukz/Pipeliner)](https://github.com/omerfarukz/Pipeliner/blob/master/LICENSE.txt)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=coverage)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)

[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=sqale_index)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=omerfarukz_Pipeliner&metric=bugs)](https://sonarcloud.io/summary/new_code?id=omerfarukz_Pipeliner)

``` csharp
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
    new Uri("https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js")
};

await extractWordsPipe.Execute(uris, Console.WriteLine); // in,void,new
```
