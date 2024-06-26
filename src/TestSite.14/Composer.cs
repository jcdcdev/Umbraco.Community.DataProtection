﻿using Umbraco.Cms.Core.Composing;
using Umbraco.Community.DataProtection.Composing;

namespace TestSite.Fourteen;

public class Composer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddUmbracoDataProtection();
    }
}
