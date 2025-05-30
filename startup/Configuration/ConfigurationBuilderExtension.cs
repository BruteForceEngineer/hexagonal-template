
namespace startup.Configuration
{
    public static class ConfigurationBuilderExtension
    {
        public static IConfigurationBuilder AddConfiguration(this IConfigurationBuilder configurationBuilder, DirectoryInfo directoryInfo)
        {
            return configurationBuilder;
        }
    }
}
