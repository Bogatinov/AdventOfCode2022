# Advent of Code 2022
https://adventofcode.com/2022/about

Advent of Code is an Advent calendar of small programming puzzles for a variety of skill sets and skill levels that can be solved in any programming language you like.

# Requirements
- [dotNET 7.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)
- Nuget package manager

# Structure
- _Advents_ - solutions to Day challenges
- _Benchmarks_ - benchmarks of each solution with [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet)
- _Puzzles_ - inputs for training + puzzle from AdventOfCode website
- _Tests_ - outputs from training + puzzle input

# Running tests
Navigate to _AdventOfCode2022.csproj_ directory and execute the [Test command](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test)
```ps
dotnet test --configuration Release
```

# Running benchmarks
Navigate to _AdventOfCode2022.csproj_ directory and execute the [Run command](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run)
```ps
dotnet run --configuration Release
```
Then choose the benchmarks to run, following the [BenchmarkDotNet official documentation](https://benchmarkdotnet.org/articles/guides/how-to-run.html#benchmarkswitcher)
