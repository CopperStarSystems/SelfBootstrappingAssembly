//  --------------------------------------------------------------------------------------
// SelfBootstrappingAssembly.ExternalDependency.Runner.cs
// 2017/02/27
//  --------------------------------------------------------------------------------------

namespace SelfBootstrappingAssembly.ExternalDependency
{
    public class Runner : IRunner
    {
        readonly ILogger logger;

        public Runner(ILogger logger)
        {
            this.logger = logger;
        }

        public void Run(string input)
        {
            logger.Log("Executing Run.");
            logger.Log($"Input was {input}");
        }
    }
}