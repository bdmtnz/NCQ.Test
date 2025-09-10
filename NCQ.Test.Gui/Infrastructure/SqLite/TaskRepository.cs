using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using System.Collections.Generic;
using System.Data.SQLite;

namespace NCQ.Test.Gui.Infrastructure.SqLite
{
    public class TaskRepository : ITaskRepository
    {
        private readonly SQLiteConnection _connection;

        public TaskRepository(SQLiteConnection connection)
        {
            _connection = connection;
        }

        public System.Threading.Tasks.Task<int> Add(Task entity)
        {
            var commandText =
                @"INSERT INTO Tasks (Description, StatusId, PriorityId, Notes, Commitment) 
                VALUES (@description, @statusId, @priorityId, @notes, @commitment);";
            using (var command = new SQLiteCommand(commandText, _connection))
            {
                command.Parameters.AddWithValue("@description", entity.Description);
                command.Parameters.AddWithValue("@statusId", entity.StatusId);
                command.Parameters.AddWithValue("@priorityId", entity.PriorityId);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                command.Parameters.AddWithValue("@commitment", entity.Commitment);
                return command.ExecuteNonQueryAsync();
            }
        }

        public System.Threading.Tasks.Task<int> Delete(Task entity)
        {
            var commandText = "DELETE FROM Tasks WHERE Id=@id;";
            var command = new SQLiteCommand(commandText, _connection);

            command.Parameters.AddWithValue("@id", entity.Id);

            return command.ExecuteNonQueryAsync();
        }

        public async System.Threading.Tasks.Task<List<Task>> Get()
        {
            var response = new List<Task>();
            var queryText = "SELECT Id, Description, StatusId, PriorityId, Notes, Commitment FROM Tasks;";

            using (var command = new SQLiteCommand(queryText, _connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var item = Task.Create(
                            reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetString(4))
                        .SetStatus(reader.GetString(2))
                        .SetPriority(reader.GetString(3))
                        .SetCommitment(reader.GetDateTime(5));

                        response.Add(item);
                    }
                }
            }
            return response;
        }

        public async System.Threading.Tasks.Task<Task> Get(string key)
        {
            Task response = default;
            var queryText =
                @"SELECT Id, Description, StatusId, PriorityId, Notes, Commitment FROM Tasks WHERE Id=@id;";
            using (var command = new SQLiteCommand(queryText, _connection))
            {
                command.Parameters.AddWithValue("@id", key);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        response = Task.Create(
                            reader.GetInt64(0),
                            reader.GetString(1),
                            reader.GetString(4))
                        .SetStatus(reader.GetString(2))
                        .SetPriority(reader.GetString(3))
                        .SetCommitment(reader.GetDateTime(5));
                    }
                }
            }
            return response;
        }

        public System.Threading.Tasks.Task<int> Update(Task entity)
        {
            var commandText = "UPDATE Tasks SET Description=@description, StatusId=@statusId, PriorityId=@priorityId, Notes=@notes, Commitment=@commitment WHERE Id=@id;";

            using (var command = new SQLiteCommand(commandText, _connection))
            {
                command.Parameters.AddWithValue("@id", entity.Id);
                command.Parameters.AddWithValue("@description", entity.Description);
                command.Parameters.AddWithValue("@statusId", entity.StatusId);
                command.Parameters.AddWithValue("@priorityId", entity.PriorityId);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                command.Parameters.AddWithValue("@commitment", entity.Commitment);
                return command.ExecuteNonQueryAsync();
            }
        }
    }
}
