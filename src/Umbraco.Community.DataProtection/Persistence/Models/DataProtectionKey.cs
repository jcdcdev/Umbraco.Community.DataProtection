using NPoco;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;

namespace Umbraco.Community.DataProtection.Persistence.Models;

[TableName(Constants.Tables.DataProtectionKeys)]
public class DataProtectionKey
{
    /// <summary>
    ///     The entity identifier of the <see cref="DataProtectionKey" />.
    /// </summary>
    [PrimaryKeyColumn(AutoIncrement = true)]
    public int Id { get; set; }

    /// <summary>
    ///     The friendly name of the <see cref="DataProtectionKey" />.
    /// </summary>
    public string? FriendlyName { get; set; }

    /// <summary>
    ///     The XML representation of the <see cref="DataProtectionKey" />.
    /// </summary>
    [SpecialDbType(SpecialDbTypes.NVARCHARMAX)]
    public string? Xml { get; set; }
}
