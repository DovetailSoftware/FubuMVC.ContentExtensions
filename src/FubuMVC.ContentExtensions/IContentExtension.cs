using System.Collections.Generic;
using FubuMVC.Core.View;

namespace FubuMVC.ContentExtensions
{
    public interface IContentExtension<T> where T : class
    {
        IEnumerable<object> GetExtensions(IFubuPage<T> page);
    }
}