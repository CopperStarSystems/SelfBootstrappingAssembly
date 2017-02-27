//  --------------------------------------------------------------------------------------
// SelfBootstrappingAssembly.ExternalDependency.ConsoleLogger.cs
// 2017/02/27
//  --------------------------------------------------------------------------------------

using System;

namespace SelfBootstrappingAssembly.ExternalDependency
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} - {message}");
        }
    }
}