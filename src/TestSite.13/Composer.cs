using Umbraco.Cms.Core.Composing;
using Umbraco.Community.DataProtection.Composing;

namespace TestSite.Thirteen;

public class Composer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddUmbracoDataProtection();
    }
}
