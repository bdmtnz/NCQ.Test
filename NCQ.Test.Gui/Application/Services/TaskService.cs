using NCQ.Test.Domain.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence.Repositories;
using NCQ.Test.Gui.Domain.Common.Contracts.Repositories.Tasks;
using NCQ.Test.Gui.Domain.Common.Contracts.Service;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text.Json;

namespace NCQ.Test.Gui.Application.Services
{
    public class TaskService : ITaskService
    {
        private readonly SQLiteConnection _connection;
        private readonly ICache _cache;
        private readonly ITaskRepository _task;

        public TaskService(ICache cache, SQLiteConnection connection, ITaskRepository task)
        {
            _connection = connection;
            _cache = cache;
            _task = task;
        }

        public async System.Threading.Tasks.Task<int> Add(Task entity)
        {
            await _connection.OpenAsync();
            var result = await _task.Add(entity);
            _connection.Close();

            var cacheKey = $"cache.{nameof(TaskService)}.get";
            _cache.Remove(cacheKey);

            return result;
        }

        public async System.Threading.Tasks.Task<int> Delete(Task entity)
        {
            await _connection.OpenAsync();
            var result = await _task.Delete(entity);
            _connection.Close();

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
                await _connection.OpenAsync();
                var result = await _task.Get();
                _connection.Close();

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
                await _connection.OpenAsync();
                var result = await _task.Get(key);
                _connection.Close();

                _cache.Set(cacheKey, result, 60 * 60);
                return result;
            }

            return cache.Value;
        }

        public async System.Threading.Tasks.Task<int> Update(Task entity)
        {
            await _connection.OpenAsync();
            var result = await _task.Update(entity);
            _connection.Close();

            var cacheKey = $"cache.{nameof(TaskService)}.get";
            _cache.Remove(cacheKey);

            var cacheByKey = $"cache.{nameof(TaskService)}.get.{entity.Id}";
            _cache.Remove(cacheByKey);

            return result;
        }

        public async System.Threading.Tasks.Task<List<Task>> Filter(TaskFilterDto dto)
        {
            await _connection.OpenAsync();
            var result = await _task.Filter(dto);
            _connection.Close();

            return result;
        }
    }
}
