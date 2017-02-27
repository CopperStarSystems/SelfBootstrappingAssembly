//  --------------------------------------------------------------------------------------
// SelfBootstrappingAssembly.ExternalDependency.ExternalDependencyAssemblyInstaller.cs
// 2017/02/27
//  --------------------------------------------------------------------------------------

using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace SelfBootstrappingAssembly.ExternalDependency.Bootstrap
{
    public class ExternalDependencyAssemblyInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ILogger>().ImplementedBy<ConsoleLogger>());
            container.Register(Component.For<IRunner>().ImplementedBy<Runner>());
        }
    }
}