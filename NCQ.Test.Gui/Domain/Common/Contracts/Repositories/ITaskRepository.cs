using NCQ.Test.Domain.Tasks;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories
{
    public interface ITaskRepository : IQuery<Task>, ICommand<Task> { }
}
