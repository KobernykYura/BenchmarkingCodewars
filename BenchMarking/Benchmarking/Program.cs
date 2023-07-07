using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Exporters;
using Benchmarking.Benchmarks;

namespace Benchmarking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfig config = ManualConfig.CreateMinimumViable()
                .AddColumn(RankColumn.Roman)
                .AddDiagnoser(MemoryDiagnoser.Default)
                .AddExporter(
                    DefaultExporters.Csv,
                    DefaultExporters.Html,
                    DefaultExporters.Markdown,
                    DefaultExporters.RPlot
                 )
                .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.SlowestToFastest));

            //BenchmarkRunner.Run<ExesAndOhsBenchmarks>(config);
            //BenchmarkRunner.Run<MaskifyBenchmark>(config);
            //BenchmarkRunner.Run<TwoToOneBenchmark>(config);
            BenchmarkRunner.Run<CreatePhoneNumberBenchmark>(config);
        }
    }
}