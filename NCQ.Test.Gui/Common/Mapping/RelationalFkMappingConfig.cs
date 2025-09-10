using Mapster;
using NCQ.Test.Domain.Terms;
using NCQ.Test.Gui.Domain.Common;

namespace NCQ.Test.Gui.Common.Mapping
{
    public class ComboItemMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Term, ComboItem>()
                .Map(dest => dest.Id, or => or.Id.Value)
                .Map(dest => dest.Text, or => or.Name);
        }
    }
}
