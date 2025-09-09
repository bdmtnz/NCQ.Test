using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Service
{
    public interface ITaskService : IQuery<Task>, ICommand<Task> { }
}
