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

        public static Term Create(string id, string code, string name = default, string parentId = default)
        {
            var _id = TermId.Create(id);
            var _parentId = string.IsNullOrEmpty(parentId) ? default : TermId.Create(parentId);
            return new Term(_id, code, name, _parentId);
        }
    }
}
