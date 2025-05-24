namespace Core.Ports.Inbound.Services
{
    public interface ITestService
    {
        public string GetSectionString();
        public static void SetSectionString(string sectionString)
        {

        }
    }
}
