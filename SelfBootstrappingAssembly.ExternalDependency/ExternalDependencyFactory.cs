//  --------------------------------------------------------------------------------------
// SelfBootstrappingAssembly.ExternalDependency.ExternalDependencyFactory.cs
// 2017/02/27
//  --------------------------------------------------------------------------------------

using SelfBootstrappingAssembly.ExternalDependency.Bootstrap;

namespace SelfBootstrappingAssembly.ExternalDependency
{
    public class ExternalDependencyFactory
    {
        public IRunner Create()
        {
            var container = Bootstrapper.Bootstrap();
            return container.Resolve<IRunner>();
        }
    }
}