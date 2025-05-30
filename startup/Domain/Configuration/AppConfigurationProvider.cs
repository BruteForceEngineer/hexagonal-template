using Microsoft.Extensions.Primitives;

namespace startup.Domain.Configuration
{
    public class AppConfigurationProvider : IConfigurationProvider
    {

        public IEnumerable<string> GetChildKeys(IEnumerable<string> earlierKeys, string? parentPath)
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {            
            throw new NotImplementedException();
        }

        public void Load()
        {
            throw new NotImplementedException();
        }

        public void Set(string key, string? value)
        {
            throw new NotImplementedException();
        }

        public bool TryGet(string key, out string? value)
        {
            throw new NotImplementedException();
        }
    }

    public class AppChangeToken : IChangeToken
    {
        public bool ActiveChangeCallbacks => throw new NotImplementedException();

        public bool HasChanged => throw new NotImplementedException();

        public IDisposable RegisterChangeCallback(Action<object?> callback, object? state)
        {
            throw new NotImplementedException();
        }
    }

}
