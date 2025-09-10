using System.Collections.Generic;

namespace NCQ.Test.Domain.Terms
{
    public sealed partial class Term
    {
        public long Id { get; set; }
        public string Code { get; private set; }
        public string Name { get; private set; }
        public long? ParentId { get; private set; }
        public IReadOnlyList<Term> Terms => _terms.AsReadOnly();

        public static Term Create(long id, string code, string name = default, long parentId = default)
        {
            long? _parentId = parentId;
            if (parentId == default)
            {
                _parentId = null;
            }
            return new Term(id, code, name, _parentId);
        }
    }
}
