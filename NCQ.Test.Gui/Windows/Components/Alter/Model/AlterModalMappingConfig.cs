using Mapster;
using NCQ.Test.Domain.Tasks;

namespace NCQ.Test.Gui.Windows.Components.Alter.Model
{
    public class AlterModalMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<Task, AlterModalViewModel>()
                .Map(dest => dest.Id, or => or.Id)
                .Map(dest => dest.Description, or => or.Description);

            config.NewConfig<AlterModalViewModel, Task>()
                .Map(dest => dest.Description, or => or.Description);
        }
    }
}
