using System;
using System.Collections.Generic;
using System.Linq;

namespace NCQ.Test.Domain.Terms
{
    public partial class Term
    {
        private readonly List<Term> _terms = new List<Term>();

        public Term() { }
        private Term(long id, string code, string name, long? parentId)
        {
            Id = id;
            Code = code;
            Name = name;
            ParentId = parentId;
        }


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
