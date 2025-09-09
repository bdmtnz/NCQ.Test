using NCQ.Test.Domain.Common.Base;
using NCQ.Test.Domain.Terms.ValueObjects;
using System;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Terms
{
    public partial class Term : AggregateRoot<TermId>
    {
        private readonly List<Term> _terms = new List<Term>();

        private Term(TermId id, string code, string name, TermId parentId) : base(id)
        {
            Code = code;
            Name = name;
            ParentId = parentId;
        }

        [Obsolete("This ctor is only for ORM")]
        protected Term() : base(default) { }
    }
}
