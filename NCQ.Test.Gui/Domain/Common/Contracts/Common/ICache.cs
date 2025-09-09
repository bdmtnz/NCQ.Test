using ErrorOr;

namespace NCQ.Test.Gui.Domain.Common.Contracts.Persistence
{
    public interface ICache
    {
        ErrorOr<Success> Set<T>(string key, T value, int timeoutInSeconds = 60);
        ErrorOr<Success> Remove(string key);
        ErrorOr<Success> Clear(string keyword);
        ErrorOr<Success> Clear();
        ErrorOr<T> Get<T>(string key);
    }
}
