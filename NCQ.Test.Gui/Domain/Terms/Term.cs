using NCQ.Test.Domain.Terms.ValueObjects;
using System.Collections.Generic;

namespace NCQ.Test.Domain.Terms
{
    public sealed partial class Term
    {
        public string Code { get; private set; }
        public string Name { get; private set; }
        public TermId ParentId { get; private set; }
        public Term Parent { get; private set; }
        public IReadOnlyList<Term> Terms => _terms.AsReadOnly();

        public static Term Create(TermId id, string code, string name = default, TermId parentId = default)
        {
            return new Term(id, code, name, parentId);
        }
    }
}
