using BenchmarkDotNet.Running;
using Benchmarking.UnitTestRunner.Benchmarks;

namespace Benchmarking.UnitTestRunner.Runners
{
    public class Tests : BenchmarkBaseTest
    {
        public Tests(BenchmarkSetupFixture benchmarkSetup) : base(benchmarkSetup) { }

        [Fact]
        public void CreatePhoneNumberBenchmark()
        {
            BenchmarkRunner.Run<CreatePhoneNumberBenchmark>(this.config);
        }

        [Fact]
        public void ExesAndOhsBenchmarks()
        {
            BenchmarkRunner.Run<ExesAndOhsBenchmarks>(this.config);
        }

        [Fact]
        public void TwoToOneBenchmark()
        {
            BenchmarkRunner.Run<TwoToOneBenchmark>(this.config);
        }

        [Fact]
        public void MaskifyBenchmark()
        {
            BenchmarkRunner.Run<MaskifyBenchmark>(this.config);
        }
    }
}