using System;

namespace NCQ.Test.Domain.Tasks
{
    public sealed partial class Task
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public long StatusId { get; set; }
        public long PriorityId { get; set; }
        public string Notes { get; set; }
        public DateTime Commitment { get; set; }
    }
}
