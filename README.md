# Benchmarking Codewars Tasks
This repository is for learning benchmarking via [BenchmarkDotNet](https://github.com/dotnet/BenchmarkDotNet).

## Codewars solutions
Own kata solutions are decoreted with `[Benchmark(Baseline = true)]`.
Each `Baseline` method is compared with top 3 kata solutions by memory consumption and execution performance.

## Benchmark run
`dotnet run --project .\Benchmarking\Benchmarking.csproj -c Release`
