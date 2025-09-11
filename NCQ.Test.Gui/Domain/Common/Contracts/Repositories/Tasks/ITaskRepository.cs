using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Repositories.Tasks;
using System.Collections.Generic;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories
{
    public interface ITaskRepository : IQuery<Task>, ICommand<Task> {
        System.Threading.Tasks.Task<List<Task>> Filter(TaskFilterDto dto);
    }
}
