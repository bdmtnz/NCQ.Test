using ErrorOr;
using Microsoft.Extensions.Caching.Memory;
using NCQ.Test.Gui.Domain.Common.Contracts.Persistence;
using System;
using System.Linq;

namespace NCQ.Test.Gui.Infrastructure.Common
{
    public class MemoryCache : ICache
    {
        private readonly IMemoryCache _cache;

        public MemoryCache(IMemoryCache cache)
        {
            _cache = cache;
        }

        public ErrorOr<Success> Set<T>(string key, T value, int timeoutInSeconds = 60)
        {
            try
            {
                var options = new MemoryCacheEntryOptions()
                .SetAbsoluteExpiration(TimeSpan.FromSeconds(timeoutInSeconds));

                _cache.Set(key, value, options);
                return Result.Success;
            }
            catch (Exception e)
            {
                return Error.Failure(description: e.Message);
            }
        }

        public ErrorOr<Success> Remove(string key)
        {
            try
            {
                var exist = _cache.TryGetValue(key, out _);
                if (!exist)
                {
                    return Error.Failure(description: "Cache don´t exists");
                }

                _cache.Remove(key);
                return Result.Success;
            }
            catch (Exception e)
            {
                return Error.Failure(description: e.Message);
            }
        }

        public ErrorOr<Success> Clear(string keyword)
        {
            try
            {
                if (_cache is Microsoft.Extensions.Caching.Memory.MemoryCache cache)
                {
                    var keys = cache.Keys.Where(k => $"{k}".Contains(keyword));
                    var keysCopy = keys.ToArray();
                    for (int i = 0; i < keysCopy.Length; i++)
                    {
                        var key = keysCopy[i];
                        _cache.Remove(key);
                    }
                }
                return Result.Success;
            }
            catch (Exception e)
            {
                return Error.Failure(description: e.Message);
            }
        }

        public ErrorOr<Success> Clear()
        {
            try
            {
                if (_cache is Microsoft.Extensions.Caching.Memory.MemoryCache cache)
                {
                    cache.Clear();
                }
                return Result.Success;
            }
            catch (Exception e)
            {
                return Error.Failure(description: e.Message);
            }
        }

        public ErrorOr<T> Get<T>(string key)
        {
            var exist = _cache.TryGetValue(key, out T value);
            if (!exist)
            {
                return Error.Failure(description: "Cache don´t exists");
            }

            return value;
        }
    }
}
