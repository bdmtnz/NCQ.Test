using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using NCQ.Test.Gui.Infrastructure.SqLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Application.Services
{
    public class TermService : ITermService
    {
        private readonly ICache _cache;
        private readonly TermRepository _term;

        public TermService(ICache cache, TermRepository term)
        {
            _cache = cache;
            _term = term;
        }

        public Task<List<Term>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Term> Get(string key)
        {
            throw new System.NotImplementedException();
        }
    }
}
