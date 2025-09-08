using NCQ.Test.Domain.Common.Base;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Tasks.ValueObjects
{
    public class TaskId : AggregateRootId<string>
    {
        public override string Value { get; protected set; }

        private TaskId() { }
        private TaskId(Ulid value)
        {
            Value = value.ToString();
        }

        public static TaskId CreateUnique()
        {
            return new TaskId(Ulid.NewUlid());
        }

        public static TaskId Create(Ulid value)
        {
            return new TaskId(value);
        }

        public static TaskId Create(string value)
        {
            return new TaskId(Ulid.Parse(value));
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
