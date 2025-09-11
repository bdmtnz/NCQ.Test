using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Repositories.Tasks
{
    public class TaskFilterBuilder
    {
        private List<SQLiteParameter> _parameters = new List<SQLiteParameter>();
        private List<string> _conditions = new List<string>() { "true" };

        private TaskFilterBuilder SetStatusId(long statusId)
        {
            if (statusId == default)
            {
                return this;
            }

            var condition = $"StatusId = @{nameof(statusId)}";
            _conditions.Add(condition);
            _parameters.Add(new SQLiteParameter($"@{nameof(statusId)}", statusId));
            return this;
        }

        private TaskFilterBuilder SetPriorityId(long priorityId)
        {
            if (priorityId == default)
            {
                return this;
            }

            var condition = $"PriorityId = @{nameof(priorityId)}";
            _conditions.Add(condition);
            _parameters.Add(new SQLiteParameter($"@{nameof(priorityId)}", priorityId));
            return this;
        }

        private TaskFilterBuilder SetCommitment(DateTime? start, DateTime? end)
        {
            if (start == null && end == null)
            {
                return this;
            }

            var condition = string.Empty;
            if (start != null && end != null)
            {
                condition = $"Commitment BETWEEN @{nameof(start)} AND @{nameof(end)}";
                _parameters.Add(new SQLiteParameter($"@{nameof(start)}", start.Value.Date));
                var endWithLastMinute = end.Value.Date.AddDays(1).AddMinutes(-1);
                _parameters.Add(new SQLiteParameter($"@{nameof(end)}", endWithLastMinute));
            }
            else if (start != null)
            {
                condition = $"Commitment >= @{nameof(start)}";
                _parameters.Add(new SQLiteParameter($"@{nameof(start)}", start.Value.Date));
            }
            else if (end != null)
            {
                condition = $"Commitment <= @{nameof(end)}";
                var endWithLastMinute = end.Value.Date.AddDays(1).AddMinutes(-1);
                _parameters.Add(new SQLiteParameter($"@{nameof(end)}", endWithLastMinute));
            }

            _conditions.Add(condition);
            return this;
        }

        public static TaskFilterBuilder Create(long statusId, long priorityId, DateTime? start, DateTime? end)
        {
            return new TaskFilterBuilder()
                .SetStatusId(statusId)
                .SetPriorityId(priorityId)
                .SetCommitment(start, end);
        }

        public string GetCondition()
        {
            return $"({string.Join($" AND {Environment.NewLine}", _conditions)})";
        }

        public SQLiteParameter[] GetParameters()
        {
            return _parameters.ToArray();
        }
    }
}
