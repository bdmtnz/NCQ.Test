using NCQ.Test.Domain.Terms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories
{
    public interface ITermRepository : IQuery<Term> {
        Task<List<Term>> GetChildren(Term term);
    }
}
