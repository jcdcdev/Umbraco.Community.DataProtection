# Umbraco.Community.DataProtection

[![Umbraco Version](https://img.shields.io/badge/Umbraco-10.4+-%233544B1?style=flat&logo=umbraco)](https://marketplace.umbraco.com/package/umbraco.community.dataprotection)
[![NuGet](https://img.shields.io/nuget/vpre/Umbraco.Community.DataProtection?color=0273B3)](https://www.nuget.org/packages/Umbraco.Community.DataProtection)
[![GitHub license](https://img.shields.io/github/license/jcdcdev/Umbraco.Community.DataProtection?color=8AB803)](https://github.com/jcdcdev/Umbraco.Community.DataProtection/LICENSE)
[![Downloads](https://img.shields.io/nuget/dt/Umbraco.Community.DataProtection?color=cc9900)](https://www.nuget.org/packages/Umbraco.Community.DataProtection/)

Simple [ASP.NET Core Data Protection](https://learn.microsoft.com/en-us/aspnet/core/security/data-protection/introduction?view=aspnetcore-8.0) for Umbraco CMS.

Data protection keys are stored in the Umbraco database.

## Quick Start

### Install

```csharp
dotnet add package Umbraco.Community.DataProtection
```

### Configure

```csharp
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;

namespace Project.Web;

public class Composer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddUmbracoDataProtection();
    }
}
```

## Contributing

Contributions to this package are most welcome! Please read the [Contributing Guidelines](https://github.com/jcdcdev/Umbraco.Community.DataProtection/blob/main/.github/CONTRIBUTING.md).

## Acknowledgments (thanks!)

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)
- jcdcdev - [jcdcdev.Umbraco.PackageTemplate](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate)