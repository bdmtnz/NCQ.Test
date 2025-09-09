using System.Threading.Tasks;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Persistence
{
    public interface ICommand<T>
    {
        Task<int> Add(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
