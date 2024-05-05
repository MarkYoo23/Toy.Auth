using Microsoft.EntityFrameworkCore;
using Toy.Auth.Domains.Models;

namespace Toy.Auth.infrastructures
{
    public class SampleContext : DbContext
    {
        public DbSet<ApplicationJwtConfig> Configs { get; set; }

    }

    public class SampleRunner 
    {
        public void Run() 
        {
            var context = new SampleContext();
            var query = context.Configs.Where(row => row.Issuer.Equals(""));
            var queryString = query.ToQueryString();



        }
    }
}
