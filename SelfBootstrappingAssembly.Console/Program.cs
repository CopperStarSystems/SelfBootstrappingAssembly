//  --------------------------------------------------------------------------------------
// SelfBootstrappingAssembly.Console.Program.cs
// 2017/02/27
//  --------------------------------------------------------------------------------------

using SelfBootstrappingAssembly.ExternalDependency;

namespace SelfBootstrappingAssembly.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ExternalDependencyFactory();
            var runner = factory.Create();
            runner.Run("Some Message");
            System.Console.ReadKey();
        }
    }
}