//  --------------------------------------------------------------------------------------
// SelfBootstrappingAssembly.ExternalDependency.Bootstrapper.cs
// 2017/02/27
//  --------------------------------------------------------------------------------------

using Castle.Windsor;
using Castle.Windsor.Installer;

namespace SelfBootstrappingAssembly.ExternalDependency.Bootstrap
{
    public static class Bootstrapper
    {
        public static IWindsorContainer Bootstrap()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            return container;
        }
    }
}