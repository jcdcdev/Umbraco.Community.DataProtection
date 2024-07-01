using System.Xml.Linq;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Infrastructure.Scoping;
using Umbraco.Community.DataProtection.Persistence.Models;
using Umbraco.Extensions;

namespace Umbraco.Community.DataProtection.Persistence;

public class UmbracoXmlRepository(IScopeProvider scopeProvider, ILogger<UmbracoXmlRepository> logger) : IXmlRepository
{
    public IReadOnlyCollection<XElement> GetAllElements()
    {
        try
        {
            using var scope = scopeProvider.CreateScope();
            var sql = scope.SqlContext.Sql().SelectAll().From<DataProtectionKey>();
            var results = scope.Database.Fetch<DataProtectionKey>(sql);
            var output = results.Select(x => XElement.Parse(x.Xml!)).WhereNotNull().ToList().AsReadOnly();
            scope.Complete();
            return output;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error getting all elements");
            return Array.Empty<XElement>();
        }
    }

    public void StoreElement(XElement element, string friendlyName)
    {
        try
        {
            using var scope = scopeProvider.CreateScope(autoComplete: false);
            var key = new DataProtectionKey
            {
                FriendlyName = friendlyName,
                Xml = element.ToString(SaveOptions.DisableFormatting)
            };
            scope.Database.Save(key);
            scope.Complete();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Error storing element");
        }
    }
}
