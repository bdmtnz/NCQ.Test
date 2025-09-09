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
                @"INSERT INTO Tasks (Id, Description, StatusId, StatusText, PriorityId, PriorityText, Notes, CommitmentStart, CommitmentEnd) 
                VALUES (@id, @description, @statusId, @statusText, @priorityId, @priorityText, @notes, @commitmentStart, @commitmentEnd);";
            using (var command = new SQLiteCommand(commandText, _connection))
            {
                command.Parameters.AddWithValue("@id", entity.Id.Value);
                command.Parameters.AddWithValue("@description", entity.Description);
                command.Parameters.AddWithValue("@statusId", entity.Status.Id.Value);
                command.Parameters.AddWithValue("@statusText", entity.Status.Text);
                command.Parameters.AddWithValue("@priorityId", entity.Priority.Id.Value);
                command.Parameters.AddWithValue("@priorityText", entity.Priority.Text);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                command.Parameters.AddWithValue("@commitmentStart", entity.Commitment.Start);
                command.Parameters.AddWithValue("@commitmentEnd", entity.Commitment.End);
                return command.ExecuteNonQueryAsync();
            }
        }

        public System.Threading.Tasks.Task<int> Delete(Task entity)
        {
            var commandText = "DELETE FROM Tasks WHERE Id=@id;";
            var command = new SQLiteCommand(commandText, _connection);

            command.Parameters.AddWithValue("@id", entity.Id.Value);

            return command.ExecuteNonQueryAsync();
        }

        public async System.Threading.Tasks.Task<List<Task>> Get()
        {
            var response = new List<Task>();
            var queryText = "SELECT Id, Description, StatusId, StatusText, PriorityId, PriorityText, Notes, CommitmentStart, CommitmentEnd FROM Tasks;";

            using (var command = new SQLiteCommand(queryText, _connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        var item = Task.Create(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(6))
                        .SetStatus(reader.GetString(2), reader.GetString(3))
                        .SetPriority(reader.GetString(4), reader.GetString(5))
                        .SetCommitment(reader.GetDateTime(7), reader.GetDateTime(8));

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
                @"SELECT Id, Description, StatusId, StatusText, PriorityId, PriorityText, Notes, CommitmentStart, CommitmentEnd FROM Tasks WHERE Id=@id;";
            using (var command = new SQLiteCommand(queryText, _connection))
            {
                command.Parameters.AddWithValue("@id", key);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (reader.Read())
                    {
                        response = Task.Create(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(6))
                        .SetStatus(reader.GetString(2), reader.GetString(3))
                        .SetPriority(reader.GetString(4), reader.GetString(5))
                        .SetCommitment(reader.GetDateTime(7), reader.GetDateTime(8));
                    }
                }
            }
            return response;
        }

        public System.Threading.Tasks.Task<int> Update(Task entity)
        {
            var commandText = "UPDATE Tasks SET Description='', StatusId='', StatusText='', PriorityId='', PriorityText='', Notes='', CommitmentStart='', CommitmentEnd='' WHERE Id='';";

            using (var command = new SQLiteCommand(commandText, _connection))
            {
                command.Parameters.AddWithValue("@description", entity.Description);
                command.Parameters.AddWithValue("@statusId", entity.Status.Id.Value);
                command.Parameters.AddWithValue("@statusText", entity.Status.Text);
                command.Parameters.AddWithValue("@priorityId", entity.Priority.Id.Value);
                command.Parameters.AddWithValue("@priorityText", entity.Priority.Text);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                command.Parameters.AddWithValue("@commitmentStart", entity.Commitment.Start);
                command.Parameters.AddWithValue("@commitmentEnd", entity.Commitment.End);
                return command.ExecuteNonQueryAsync();
            }
        }
    }
}
