using FubuCore;
using FubuMVC.Core;
using FubuMVC.Core.Registration;
using FubuMVC.Core.View;
using FubuTestingSupport;
using NUnit.Framework;

namespace FubuMVC.ContentExtensions.Tests
{
    [TestFixture]
    public class NamespaceImportsTester
    {
        [Test]
        public void ensure_namespaces_are_imported()
        {
            var registry = new FubuRegistry();
            registry.Import<ContentExtensionsRegistration>();

            var graph = BehaviorGraph.BuildFrom(registry);
            var commonViewNamespaces = graph.Services.DefaultServiceFor<CommonViewNamespaces>().Value.As<CommonViewNamespaces>();
            commonViewNamespaces.Namespaces.ShouldContain(typeof(ContentExtensionGraph).Namespace);
        }
    }
}