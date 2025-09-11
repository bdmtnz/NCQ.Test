using System;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Repositories.Tasks
{
    public class TaskFilterDto
    {
        public long StatusId { get; set; }
        public long PriorityId { get; set; }
        public DateTime? CommitmentStart { get; set; }
        public DateTime? CommitmentEnd { get; set; }
    }
}
