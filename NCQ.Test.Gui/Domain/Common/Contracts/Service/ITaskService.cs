using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Service
{
    public interface ITaskService : IQuery<Task>, ICommand<Task> { }
}
