using Efcore_DbLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore_AppConsole.Configuration
{
    public static class AppSetup
    {
        static IConfigurationRoot _configuration;
        public static DbContextOptionsBuilder<AdventureWorksContext> _optionsBuilder;

       public static void BuildOptions()
        {
            _configuration = ConfigurationBuilderSingleton.ConfigurationRoot;
            _optionsBuilder = new DbContextOptionsBuilder<AdventureWorksContext>();
            _optionsBuilder.UseSqlServer(_configuration.GetConnectionString("AdventureWorks"));
        }

        public static void DisplayConnectionString()
        {
            Console.WriteLine($"CNSTR: {_configuration.GetConnectionString("AdventureWorks")}");
        }
    }
}
