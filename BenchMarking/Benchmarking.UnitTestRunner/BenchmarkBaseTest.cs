using BenchmarkDotNet.Configs;
using Benchmarking.UnitTestRunner.Runners;

namespace Benchmarking.UnitTestRunner
{
    public class BenchmarkBaseTest : IClassFixture<BenchmarkSetupFixture>
    {
        protected IConfig config;

        public BenchmarkBaseTest(BenchmarkSetupFixture benchmarkSetup)
        {
            this.config = benchmarkSetup.BenchmarkConfig;
        }
    }
}