using System.Threading.Tasks;
using ASPANGULAR.Models.TokenAuth;
using ASPANGULAR.Web.Controllers;
using Shouldly;
using Xunit;

namespace ASPANGULAR.Web.Tests.Controllers
{
    public class HomeController_Tests: ASPANGULARWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}