using System;

namespace Abp.Domain.Entities.Auditing
{
    /// <summary>
    ///     A shortcut of <see cref="CreationAuditedEntity" /> for most used primary key type (<see cref="int" />).
    /// </summary>
    [Serializable]
    public abstract class CreationAuditedEntity : CreationAuditedEntity<int, int>
    {
    }
}