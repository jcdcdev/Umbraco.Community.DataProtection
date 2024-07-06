using Microsoft.Extensions.Options;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.IO;
using Umbraco.Cms.Core.PropertyEditors;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Strings;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Cms.Infrastructure.Packaging;
using Umbraco.Community.DataProtection.Persistence.Models;

namespace Umbraco.Community.DataProtection.Persistence;

public class DataProtectionMigration(
    IPackagingService packagingService,
    IMediaService mediaService,
    MediaFileManager mediaFileManager,
    MediaUrlGeneratorCollection mediaUrlGenerators,
    IShortStringHelper shortStringHelper,
    IContentTypeBaseServiceProvider contentTypeBaseServiceProvider,
    IMigrationContext context,
    IOptions<PackageMigrationSettings> packageMigrationsSettings)
    : PackageMigrationBase(packagingService, mediaService, mediaFileManager, mediaUrlGenerators, shortStringHelper, contentTypeBaseServiceProvider,
        context, packageMigrationsSettings)
{
    protected override void Migrate()
    {
        if (!TableExists(Constants.Tables.DataProtectionKeys))
        {
            Create.Table<DataProtectionKey>().Do();
        }
    }
}
