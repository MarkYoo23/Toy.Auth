using Toy.Auth.Domains.Configs;
using Toy.Auth.Domains.Models;

namespace Toy.Auth.Test.Mocks
{
    internal class MockApplicationConfig : IApplicationConfig
    {
        public ApplicationJwtConfig GetJwtConfig()
        {
            return new ApplicationJwtConfig()
            {
                SecretKey = "53AE27BC14C7D618F29C6A9D81EC3271CE0FBB5D63819FAB36D9A1D04FBC0D67",
                Audience = "localhost:5001",
                Issuer = "localhost:5001",
            };
        }
    }
}
