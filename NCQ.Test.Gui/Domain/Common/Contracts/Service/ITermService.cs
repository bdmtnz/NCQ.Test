using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Service
{
    public interface ITermService : IQuery<Term> {
        Task<Term> GetWithChildren(string code);
    }
}
