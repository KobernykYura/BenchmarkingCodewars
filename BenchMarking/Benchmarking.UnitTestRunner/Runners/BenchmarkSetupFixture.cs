using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnosers;
using BenchmarkDotNet.Exporters.Json;
using BenchmarkDotNet.Jobs;
using Perfolizer.Horology;

namespace Benchmarking.UnitTestRunner.Runners
{
    public class BenchmarkSetupFixture
    {
        /// <summary>
        /// Configuration object test class.
        /// </summary>
        public readonly IConfig BenchmarkConfig;

        /// <summary>
        /// xUnit setup
        /// </summary>
        public BenchmarkSetupFixture()
        {
            this.BenchmarkConfig = this.GetBenchmarkConfig();
        }

        /// <summary>
        /// Benchmark setup factory
        /// </summary>
        /// <returns></returns>
        protected virtual IConfig GetBenchmarkConfig()
        {
            // Copied from RecommendedConfig.cs at dotnet/performance with reference to BenchmarkDotNet.Extensions
            // More details at: https://github.com/dotnet/performance/blob/51d8f8483b139bb1edde97f917fa436671693f6f/src/harness/BenchmarkDotNet.Extensions/RecommendedConfig.cs

            return DefaultConfig.Instance
                .WithArtifactsPath("./ArtifactsBenchmark")
                .AddJob(Job.Default
                    .WithWarmupCount(1) // 1 warmup is enough for our purpose
                    .WithIterationTime(TimeInterval.FromMilliseconds(250)) // the default is 0.5s per iteration, which is slighlty too much for us
                    .WithMinIterationCount(15)
                    .WithMaxIterationCount(20) // we don't want to run more that 20 iterations
                    .AsDefault()
                ) // tell BDN that this are our default settings
                .AddDiagnoser(MemoryDiagnoser.Default) // MemoryDiagnoser is enabled by default
                .AddExporter(JsonExporter.Full) // make sure we export to Json (for BenchView integration purpose)
                .AddColumn(
                    StatisticColumn.Median,
                    StatisticColumn.Min,
                    StatisticColumn.Max,
                    RankColumn.Arabic
                );
        }
    }
}