using NCQ.Test.Domain.Common.Base;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Tasks.ValueObjects
{
    public class RelationalFk : ValueObject
    {
        public string Id { get; protected set; }
        public string Text { get; protected set; }

        private RelationalFk(string id, string text)
        {
            Id = id;
            Text = text;
        }

        public static RelationalFk Create(string id, string text)
        {
            return new RelationalFk(id, text);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
        }
    }
}
