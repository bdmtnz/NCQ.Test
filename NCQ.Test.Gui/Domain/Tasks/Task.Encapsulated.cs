using NCQ.Test.Domain.Common.Base;
using NCQ.Test.Domain.Tasks.ValueObjects;
using NCQ.Test.Domain.Terms.ValueObjects;
using System;

namespace NCQ.Test.Domain.Tasks
{
    public sealed partial class Task : AggregateRoot<TaskId>
    {
        [Obsolete("This ctor is only for ORM")]
        protected Task() : base(default) { }
        private Task(
            TaskId id, 
            string description,
            string notes) : base(id)
        {
            Id = id;
            Description = description;
            Notes = notes;
        }

        public static Task Create(string description, string notes)
        {
            var id = TaskId.CreateUnique();
            return new Task(id, description, notes);
        }

        public Task SetStatus(TermId statusId, string statusName)
        {
            Status = RelationalFk<TermId>.Create(statusId, statusName);
            return this;
        }

        public Task SetPriority(TermId priorityId, string priorityName)
        {
            Status = RelationalFk<TermId>.Create(priorityId, priorityName);
            return this;
        }

        public Task SetCommitment(DateTime? start, DateTime? end)
        {
            Commitment = DateRange.Create(start, end);
            return this;
        }
    }
}
