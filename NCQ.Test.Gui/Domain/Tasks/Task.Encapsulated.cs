using NCQ.Test.Domain.Common.Base;
using System;

namespace NCQ.Test.Domain.Tasks
{
    public sealed partial class Task
    {
        public Task() { }
        private Task(
            long id, 
            string description,
            string notes)
        {
            Id = id;
            Description = description;
            Notes = notes;
        }

        public static Task Create(long id, string description, string notes)
        {
            return new Task(id, description, notes);
        }

        public Task SetStatus(long statusId)
        {
            StatusId = statusId;
            return this;
        }

        public Task SetPriority(long priorityId)
        {
            PriorityId = priorityId;
            return this;
        }

        public Task SetCommitment(DateTime commitment)
        {
            Commitment = commitment;
            return this;
        }
    }
}
