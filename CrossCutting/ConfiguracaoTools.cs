
using Microsoft.Extensions.Configuration;
namespace CrossCutting
{
    public class ConfiguracaoTools
    {
        public static string RetornaVariavelConfiguracoes(string variavel)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);
            IConfiguration config = builder.Build();

            var result= config[variavel];
            return result;
        }
    }
}
