using NCQ.Test.Domain.Common.Base;

namespace NCQ.Test.Domain.Common.Contracts
{
    public interface IEntity<EId> where EId : ValueObject { }
}
