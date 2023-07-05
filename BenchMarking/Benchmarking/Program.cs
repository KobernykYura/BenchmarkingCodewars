using BenchmarkDotNet.Running;
using Benchmarking.Benchmarks;

namespace Benchmarking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<ExesAndOhsBenchmarks>();
            BenchmarkRunner.Run<MaskifyBenchmark>();
        }
    }
}