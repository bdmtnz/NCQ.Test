namespace NCQ.Test.Domain.Common.Base
{
    public abstract class AggregateRootId<AId> : ValueObject
    {
        public abstract AId Value { get; protected set; }
    }
}
