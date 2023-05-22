using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toy.Auth.Applications;
using Toy.Auth.infrastructures;
using Toy.Auth.Test.Mocks;
using Xunit;

namespace Toy.Auth.Test.Applications
{
    public class MicrosoftJwtCreateServiceTest
    {

        [Fact]
        public void Test() 
        {
            var applicationConfig = new MockApplicationConfig();
            var service = new MicrosoftJwtCreateService(applicationConfig);
            var actualToken = service.CreateToken();

            var isVaild = service.VaildToken(actualToken);
            Assert.True(isVaild);
        }

    }
}
