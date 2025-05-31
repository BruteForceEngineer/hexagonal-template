namespace startup.Domain.Configuration
{
    public class AppConfigurationSource : IConfigurationSource
    {
        public AppConfigurationSource()
        {
            
        }

        public AppConfigurationSource(DirectoryInfo directoryInfo)
        {
                
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new AppConfigurationProvider();
        }
    }
}
