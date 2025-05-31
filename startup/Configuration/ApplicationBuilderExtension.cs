namespace startup.Configuration
{
    public static class ApplicationBuilderExtension
    {
        public static void AddServicesConfiguration(this IHostApplicationBuilder builder)
        {
            List<DirectoryInfo> configurationDirectories = [.. Directory.GetDirectories(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "var")).Select(d => new DirectoryInfo(d))];

            foreach (DirectoryInfo directoryInfo in configurationDirectories)
            {
                List<ServiceDescriptor> serviceDescriptors = [.. builder.Services.Where(s => s.ServiceType.Name.Contains(directoryInfo.Name))];
                if (serviceDescriptors.Count == 1)
                {
                    builder.Configuration.AddConfiguration(directoryInfo);
                }
            }
        }
    }
}
