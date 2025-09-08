using NCQ.Test.Domain.Common.Base;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Tasks.ValueObjects
{
    public class RelationalFk<TId> : ValueObject
        where TId : ValueObject
    {
        public TId Id { get; protected set; }
        public string Text { get; protected set; }

        [Obsolete("For EF", true)]
        protected RelationalFk() { }
        private RelationalFk(TId id, string text)
        {
            Id = id;
            Text = text;
        }

        public static RelationalFk<TId> Create(TId id, string text)
        {
            return new RelationalFk<TId>(id, text);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
        }
    }
}
