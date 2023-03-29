using Microsoft.Extensions.Configuration;

namespace NSE.Core.Utils
{
    public static class ConfigurationExtensions
    {
        public static string GetMessageBusConnection(this IConfiguration configuration, string name)
        {
            return configuration?.GetSection("MessageQueueConnection")?[name];
        }
    }
}
