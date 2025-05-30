using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace startup.Configuration
{
    public static class ApplicationBuilderExtension
    {
        public static void AddServicesConfiguration(this IHostApplicationBuilder builder)
        {
            List<DirectoryInfo> configurationDirectories = Directory.GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "var")).Select(d => new DirectoryInfo(d)).ToList();

            foreach (DirectoryInfo directoryInfo in configurationDirectories)
            {

                builder.Configuration.AddConfiguration(directoryInfo);
            }
        }
    }
}
