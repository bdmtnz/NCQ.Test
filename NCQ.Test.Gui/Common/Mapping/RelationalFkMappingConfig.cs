using Mapster;
using NCQ.Test.Domain.Tasks.ValueObjects;
using NCQ.Test.Domain.Terms;

namespace NCQ.Test.Gui.Common.Mapping
{
    public class RelationalFkMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Term, RelationalFk>()
                .Map(dest => dest.Id, or => or.Id.Value)
                .Map(dest => dest.Text, or => or.Name);
        }
    }
}
