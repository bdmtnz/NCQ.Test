using System.Collections.Generic;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Persistence
{
    public interface IQuery<T> where T : class
    {
        Task<List<T>> Get();
        Task<T> Get(string key);
    }
}
