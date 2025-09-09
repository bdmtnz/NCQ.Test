using NCQ.Test.Domain.Tasks.ValueObjects;
using NCQ.Test.Domain.Terms.ValueObjects;

namespace NCQ.Test.Domain.Tasks
{
    public sealed partial class Task
    {
        public string Description { get; set; }
        public RelationalFk<TermId> Status { get; set; }
        public RelationalFk<TermId> Priority { get; set; }
        public string Notes { get; set; }
        public DateRange Commitment { get; set; }
    }
}
