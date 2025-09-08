using NCQ.Test.Domain.Common.Base;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Terms.ValueObjects
{
    public sealed class TermId : AggregateRootId<string>
    {
        public override string Value { get; protected set; }

        private TermId() { }

        private TermId(Ulid value)
        {
            Value = value.ToString();
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value.ToString();
        }

        public static TermId CreateUnique()
        {
            return new TermId(Ulid.NewUlid());
        }

        public static TermId Create(Ulid value)
        {
            return new TermId(value);
        }

        public static TermId Create(string value)
        {
            return new TermId(Ulid.Parse(value));
        }
    }
}
