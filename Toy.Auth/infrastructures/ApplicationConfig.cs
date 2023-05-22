using Toy.Auth.Domains.Configs;
using Toy.Auth.Domains.Models;

namespace Toy.Auth.infrastructures
{
    public class ApplicationConfig : IApplicationConfig
    {
        private readonly IConfiguration _configuration;

        public ApplicationConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public ApplicationJwtConfig GetJwtConfig() 
        {
            return _configuration.GetSection("Jwt").Get<ApplicationJwtConfig>();          
        }
    }
}
