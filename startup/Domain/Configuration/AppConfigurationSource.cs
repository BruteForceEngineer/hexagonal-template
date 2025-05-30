namespace startup.Domain.Configuration
{
    public class AppConfigurationSource : IConfigurationSource
    {
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new AppConfigurationProvider();
        }
    }
}
