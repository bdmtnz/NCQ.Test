using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Application.Services
{
    public class TermService : ITermService
    {
        private readonly SQLiteConnection _connection;
        private readonly ICache _cache;
        private readonly ITermRepository _term;

        public TermService(ICache cache, SQLiteConnection connection, ITermRepository term)
        {
            _cache = cache;
            _connection = connection;
            _term = term;
        }

        public async Task<List<Term>> Get()
        {
            var cacheKey = $"cache.{nameof(TermService)}.get";

            var cache = _cache.Get<List<Term>>(cacheKey);
            if (cache.IsError)
            {
                await _connection.OpenAsync();
                var result = await _term.Get();
                _connection.Close();

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
                await _connection.OpenAsync();
                var result = await _term.Get(key);
                _connection.Close();

                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }

        public async Task<Term> GetWithChildren(string code)
        {
            var cacheKey = $"cache.{nameof(TermService)}.get.children.{code}";

            var cache = _cache.Get<Term>(cacheKey);
            if (cache.IsError)
            {
                await _connection.OpenAsync();
                var result = await _term.Get(code);
                if (result != null)
                {
                    var children = await _term.GetChildren(result);
                    result.SetChildren(children);
                }
                _connection.Close();

                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }
    }
}
