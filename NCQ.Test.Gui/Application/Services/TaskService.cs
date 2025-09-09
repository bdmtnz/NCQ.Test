using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using NCQ.Test.Gui.Infrastructure.SqLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NCQ.Test.Gui.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ICache _cache;
        private readonly TaskRepository _task;

        public TaskService(ICache cache, TaskRepository task)
        {
            _cache = cache;
            _task = task;
        }

        public Task<int> Add(Task entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Delete(Task entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Task>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Task> Get(string key)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> Update(Task entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
