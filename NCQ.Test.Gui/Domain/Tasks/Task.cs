using System;

namespace NCQ.Test.Domain.Tasks
{
    public sealed partial class Task
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string StatusId { get; set; }
        public string PriorityId { get; set; }
        public string Notes { get; set; }
        public DateTime Commitment { get; set; }
    }
}
