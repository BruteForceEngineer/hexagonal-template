using Core.Ports.Inbound.Services;

namespace Core.Services
{
    public class TestService : ITestService
    {
        public static string SectionString { get; set; }

        public string GetSectionString()
        {
            return SectionString;
        }

        public static void SetSectionString(string sectionString)
        {
            SectionString = sectionString;
        }
    }
}
