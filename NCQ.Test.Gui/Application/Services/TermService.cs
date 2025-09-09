using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Application.Services
{
    public class TermService : ITermService
    {
        private readonly ICache _cache;
        private readonly ITermRepository _term;

        public TermService(ICache cache, ITermRepository term)
        {
            _cache = cache;
            _term = term;
        }

        public async Task<List<Term>> Get()
        {
            var cacheKey = $"cache.{nameof(TermService)}.get";

            var cache = _cache.Get<List<Term>>(cacheKey);
            if (cache.IsError)
            {
                var result = await _term.Get();
                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }

        public async Task<Term> Get(string key)
        {
            var cacheKey = $"cache.{nameof(TermService)}.get.{key}";

            var cache = _cache.Get<Term>(cacheKey);
            if (cache.IsError)
            {
                var result = await _term.Get(key);
                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }
    }
}
