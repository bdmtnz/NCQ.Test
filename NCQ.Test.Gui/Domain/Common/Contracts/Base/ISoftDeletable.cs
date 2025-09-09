using System;

namespace NCQ.Test.Domain.Common.Contracts
{
    public interface ISoftDeletable
    {
        DateTime? DeletedOnUtc { set; get; }
        void ApplySoftDelete();
    }
}
