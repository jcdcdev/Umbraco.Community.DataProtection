using System.Reflection;
using jcdcdev.Umbraco.Core.Extensions;
using Umbraco.Cms.Core.Manifest;
using Umbraco.Cms.Infrastructure.Manifest;

namespace Umbraco.Community.DataProtection.Composing;

public class PackageManifestReader : IPackageManifestReader
{
    public Task<IEnumerable<PackageManifest>> ReadPackageManifestsAsync()
    {
        var packageManifest = new PackageManifest
        {
            Name = Constants.PackageName,
            Version = Assembly.GetAssembly(typeof(PackageManifestReader))?.GetName().Version?.ToSemVer()?.ToString() ?? "0.1.0",
            AllowPublicAccess = false,
            AllowTelemetry = false,
            Extensions = []
        };

        return Task.FromResult<IEnumerable<PackageManifest>>([packageManifest]);
    }
}
