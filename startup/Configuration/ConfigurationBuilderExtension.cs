
using startup.Domain.Configuration;

namespace startup.Configuration
{
    public static class ConfigurationBuilderExtension
    {
        public static IConfigurationBuilder AddConfiguration(this IConfigurationBuilder configurationBuilder, DirectoryInfo directoryInfo)
        {
            IConfigurationSource configurationSource = new AppConfigurationSource(directoryInfo);
            configurationBuilder.Add(configurationSource);
            return configurationBuilder;
        }
    }
}
