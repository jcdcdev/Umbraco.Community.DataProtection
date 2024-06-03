using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Community.DataProtection.Persistence;
using Umbraco.Extensions;

namespace Umbraco.Community.DataProtection.Composing;

public static class UmbracoBuilderExtensions
{
    public static IDataProtectionBuilder AddUmbracoDataProtection(this IUmbracoBuilder builder, string? applicationDiscriminator = null, Action<KeyManagementOptions>? configureOptions = null)
    {
        builder.PackageMigrationPlans()!.Add<MigrationPlan>();
        builder.Services.AddSingleton<UmbracoXmlRepository>();
        builder.Services.AddSingleton<IConfigureOptions<KeyManagementOptions>>(services =>
        {
            var repository = services.GetRequiredService<UmbracoXmlRepository>();
            return new ConfigureOptions<KeyManagementOptions>(options =>
            {
                options.XmlRepository = repository;
                options.AutoGenerateKeys = true;
                configureOptions?.Invoke(options);
            });
        });

        return builder.Services.AddDataProtection(x =>
        {
            if (!applicationDiscriminator.IsNullOrWhiteSpace())
            {
                x.ApplicationDiscriminator = applicationDiscriminator;
            }
        });
    }
}
