using jcdcdev.Umbraco.Core.Extensions;
using Umbraco.Cms.Core.Manifest;

namespace Umbraco.Community.DataProtection;

public class ManifestFilter : IManifestFilter
{
    public void Filter(List<PackageManifest> manifests)
    {
        manifests.Add(new PackageManifest
        {
            Version = EnvironmentExtensions.CurrentAssemblyVersion()?.ToSemVer()?.ToString() ?? "0.1.0",
            PackageName = Constants.PackageName,
            AllowPackageTelemetry = true
        });
    }
}
