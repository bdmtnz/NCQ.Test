using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
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

        public async Task<List<Term>> Get()
        {
            var response = new List<Term>();
            var queryText = "SELECT Id, Code, Name, ParentId FROM Terms;";

            using (var command = new SQLiteCommand(queryText, _connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var item = Term.Create(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3)
                        );
                        response.Add(item);
                    }
                }
            }
            return response;
        }

        public async Task<Term> Get(string key)
        {
            Term response = default;
            var queryText = "SELECT Id, Code, Name, ParentId FROM Terms WHERE Code=@key;";

            using (var command = new SQLiteCommand(queryText, _connection))
            {
                command.Parameters.AddWithValue("@key", key);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        response = Term.Create(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3)
                        );
                    }
                }
            }
            return response;
        }

        public async Task<List<Term>> GetChildren(Term parent)
        {
            var response = new List<Term>();
            var queryText =
                @"SELECT Id, Code, Name, ParentId FROM Terms WHERE ParentId=@id;";

            using (var command = new SQLiteCommand(queryText, _connection))
            {
                command.Parameters.AddWithValue("@id", parent.Id.Value);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var item = Term.Create(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3)
                        );
                        response.Add(item);
                    }
                }
            }
            return response;
        }
    }
}
