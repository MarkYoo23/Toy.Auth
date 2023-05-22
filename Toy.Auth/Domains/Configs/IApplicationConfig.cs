using Toy.Auth.Domains.Models;

namespace Toy.Auth.Domains.Configs
{
    public interface IApplicationConfig
    {
        ApplicationJwtConfig GetJwtConfig();
    }
}
