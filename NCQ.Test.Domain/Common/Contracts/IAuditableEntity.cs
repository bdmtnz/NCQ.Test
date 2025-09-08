using System;

namespace NCQ.Test.Domain.Common.Contracts
{
    public interface IAuditableEntity
    {
        DateTime CreatedOnUtc { get; }
        DateTime? UpdatedOnUtc { get; }
    }
}
