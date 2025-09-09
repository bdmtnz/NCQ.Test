using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Infrastructure.SqLite
{
    public class TermRepository : ITermRepository
    {
        private readonly SQLiteConnection _connection;

        public TermRepository(SQLiteConnection connection)
        {
            _connection = connection;
        }

        public Task<List<Term>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Term> Get(string key)
        {
            throw new NotImplementedException();
        }
    }
}
