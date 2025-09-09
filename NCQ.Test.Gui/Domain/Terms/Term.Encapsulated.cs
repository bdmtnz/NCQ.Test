using NCQ.Test.Domain.Common.Base;
using NCQ.Test.Domain.Terms.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public Term SetChildren(List<Term> children)
        {
            var areChildren = children.All(c => c.ParentId == Id);
            if (areChildren)
            {
                _terms.AddRange(children);
            }
            return this;
        }
    }
}
