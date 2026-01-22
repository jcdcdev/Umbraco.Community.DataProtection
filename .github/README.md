# Umbraco.Community.DataProtection

[![Umbraco Marketplace](https://img.shields.io/badge/Umbraco Marketplace-%23f5c1bc?logo=umbraco&logoColor=162335)](https://marketplace.umbraco.com/package/Umbraco.Community.DataProtection)
[![GitHub](https://img.shields.io/badge/GitHub-1?logo=github&color=232925)](https://github.com/jcdcdev/Umbraco.Community.DataProtection)
[![NuGet Downloads](https://img.shields.io/nuget/dt/Umbraco.Community.DataProtection?labelColor=4536d3&color=4536d3&label=NuGet&logo=nuget)](https://www.nuget.org/packages/Umbraco.Community.DataProtection)
[![Project Website](https://img.shields.io/badge/Project Website-jcdcdev?color=3c4834&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxNiIgaGVpZ2h0PSIxNiIgZmlsbD0id2hpdGUiIGNsYXNzPSJiaSBiaS1wYy1kaXNwbGF5IiB2aWV3Qm94PSIwIDAgMTYgMTYiPgogIDxwYXRoIGQ9Ik04IDFhMSAxIDAgMCAxIDEtMWg2YTEgMSAwIDAgMSAxIDF2MTRhMSAxIDAgMCAxLTEgMUg5YTEgMSAwIDAgMS0xLTF6bTEgMTMuNWEuNS41IDAgMSAwIDEgMCAuNS41IDAgMCAwLTEgMG0yIDBhLjUuNSAwIDEgMCAxIDAgLjUuNSAwIDAgMC0xIDBNOS41IDFhLjUuNSAwIDAgMCAwIDFoNWEuNS41IDAgMCAwIDAtMXpNOSAzLjVhLjUuNSAwIDAgMCAuNS41aDVhLjUuNSAwIDAgMCAwLTFoLTVhLjUuNSAwIDAgMC0uNS41TTEuNSAyQTEuNSAxLjUgMCAwIDAgMCAzLjV2N0ExLjUgMS41IDAgMCAwIDEuNSAxMkg2djJoLS41YS41LjUgMCAwIDAgMCAxSDd2LTRIMS41YS41LjUgMCAwIDEtLjUtLjV2LTdhLjUuNSAwIDAgMSAuNS0uNUg3VjJ6Ii8+Cjwvc3ZnPg==)](https://jcdc.dev/umbraco-packages/data-protection)



Simple [ASP.NET Core Data Protection](https://learn.microsoft.com/en-us/aspnet/core/security/data-protection/introduction) for Umbraco CMS.

Data protection keys are stored in the Umbraco database.

## Installation

### Install Package

```powershell
dotnet add package Umbraco.Community.DataProtection
```

## Quick Start

```csharp title="Composer.cs"
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

Contributions to this package are most welcome! Please visit the [Contributing](https://github.com/jcdcdev/Umbraco.Community.DataProtection/contribute) page.

## Acknowledgements (Thanks)

- LottePitcher - [opinionated-package-starter](https://github.com/LottePitcher/opinionated-package-starter)
- jcdcdev - [jcdcdev.Umbraco.PackageTemplate](https://github.com/jcdcdev/jcdcdev.Umbraco.PackageTemplate)



