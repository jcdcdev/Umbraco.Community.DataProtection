using Umbraco.Cms.Core.Packaging;

namespace Umbraco.Community.DataProtection.Persistence;

public class MigrationPlan() : PackageMigrationPlan(Constants.PackageName)
{
    protected override void DefinePlan()
    {
        To<DataProtectionMigration>(nameof(DataProtectionMigration));
    }
}
