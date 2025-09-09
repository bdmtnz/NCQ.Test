using NCQ.Test.Domain.Tasks.ValueObjects;
using NCQ.Test.Domain.Terms.ValueObjects;
using System;

namespace NCQ.Test.Domain.Tasks
{
    public sealed partial class Task
    {
        public string Description { get; set; }
        public RelationalFk<TermId> Status { get; set; }
        public RelationalFk<TermId> Priority { get; set; }
        public string Notes { get; set; }
        public DateTime Commitment { get; set; }
    }
}
