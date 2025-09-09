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

        public static Task Create(string id, string description, string notes)
        {
            var _id = TaskId.Create(id);
            return new Task(_id, description, notes);
        }

        public static Task Create(string description, string notes)
        {
            var id = TaskId.CreateUnique();
            return new Task(id, description, notes);
        }

        public Task SetStatus(string statusId, string statusName)
        {
            var _statusId = TermId.Create(statusId);
            Status = RelationalFk<TermId>.Create(_statusId, statusName);
            return this;
        }

        public Task SetPriority(string priorityId, string priorityName)
        {
            var _priorityId = TermId.Create(priorityId);
            Status = RelationalFk<TermId>.Create(_priorityId, priorityName);
            return this;
        }

        public Task SetCommitment(DateTime commitment)
        {
            Commitment = commitment;
            return this;
        }
    }
}
