using FubuMVC.Core;
using FubuMVC.Core.View;

namespace FubuMVC.ContentExtensions
{
    public class ContentExtensionsRegistration : IFubuRegistryExtension 
    {
        public void Configure(FubuRegistry registry)
        {
            registry.AlterSettings<CommonViewNamespaces>(x => x.AddForType<ContentExtensionsRegistration>());
        }
    }
}