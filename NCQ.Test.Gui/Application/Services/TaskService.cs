using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using System.Collections.Generic;

namespace NCQ.Test.Gui.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly ICache _cache;
        private readonly ITaskRepository _task;

        public TaskService(ICache cache, ITaskRepository task)
        {
            _cache = cache;
            _task = task;
        }

        public async System.Threading.Tasks.Task<int> Add(Task entity)
        {
            var result = await _task.Add(entity);

            var cacheKey = $"cache.{nameof(TaskService)}.get";
            _cache.Remove(cacheKey);

            return result;
        }

        public async System.Threading.Tasks.Task<int> Delete(Task entity)
        {
            var result = await _task.Delete(entity);

            var cacheKey = $"cache.{nameof(TaskService)}.get";
            _cache.Remove(cacheKey);

            var cacheByKey = $"cache.{nameof(TaskService)}.get.{entity.Id}";
            _cache.Remove(cacheByKey);

            return result;
        }

        public async System.Threading.Tasks.Task<List<Task>> Get()
        {
            var cacheKey = $"cache.{nameof(TaskService)}.get";

            var cache = _cache.Get<List<Task>>(cacheKey);
            if (cache.IsError)
            {
                var result = await _task.Get();
                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }

        public async System.Threading.Tasks.Task<Task> Get(string key)
        {
            var cacheKey = $"cache.{nameof(TaskService)}.get.{key}";

            var cache = _cache.Get<Task>(cacheKey);
            if (cache.IsError)
            {
                var result = await _task.Get(key);
                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }

        public async System.Threading.Tasks.Task<int> Update(Task entity)
        {
            var result = await _task.Update(entity);

            var cacheKey = $"cache.{nameof(TaskService)}.get";
            _cache.Remove(cacheKey);

            var cacheByKey = $"cache.{nameof(TaskService)}.get.{entity.Id}";
            _cache.Remove(cacheByKey);

            return result;
        }
    }
}
