namespace Jcf.AM.Control.Api.Extensions.Helpers
{
    public static class ConfigurationHelper
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string GetConfiguration(string config)
        {
            try
            {
                return _configuration[config];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());   
                return string.Empty;
            }
        }
    }
}
