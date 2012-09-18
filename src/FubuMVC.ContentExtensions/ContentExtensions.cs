using System.Web;
using FubuMVC.Core;
using FubuMVC.Core.View;

namespace FubuMVC.ContentExtensions
{
    public static class ContentExtensions
    {
        public static IHtmlString WriteExtensions<T>(this IFubuPage<T> page) where T : class
        {
            return page.Get<ContentExtensionGraph>().ApplyExtensions(page);
        }

        public static IHtmlString WriteExtensions<T>(this IFubuPage<T> page, string tag) where T : class
        {
            return page.Get<ContentExtensionGraph>().ApplyExtensions(page, tag);
        }

        public static ExtensionsExpression Extensions(this FubuRegistry registry)
        {
            return new ExtensionsExpression(registry);
        }
    }
}