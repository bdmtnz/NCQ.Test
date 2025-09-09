using NCQ.Test.Domain.Common.Base;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Tasks.ValueObjects
{
    public class DateRange : ValueObject
    {
        public DateTime? Start { get; protected set; }
        public DateTime? End { get; protected set; }

        [Obsolete("For EF", true)]
        protected DateRange() { }
        private DateRange(DateTime? start, DateTime? end)
        {
            Start = start;
            End = end;
        }

        public static DateRange Create(DateTime? start, DateTime? end)
        {
            return new DateRange(start, end);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return new { Start, End };
        }
    }
}
