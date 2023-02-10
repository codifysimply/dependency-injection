using Lifetime.Sample.WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lifetime.Sample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private readonly IFirstService firstService;
        private readonly ISecondService secondService;

        public RandomController(IFirstService firstService, ISecondService secondService)
        {
            this.firstService = firstService;
            this.secondService = secondService;
        }

        [HttpGet]
        public Dictionary<string,object> Get()
        {
            firstService.Genearet();

            return new Dictionary<string, object>
            {
                ["Random_Number_Service_1"] = firstService.Get(),
                ["Random_Number_Service_2"] = secondService.Get(),
                ["Instance_Hashcode_Service_1"] = firstService.GetRandomHashCode(),
                ["Instance_Hashcode_Service_2"] = secondService.GetRandomHashCode()
            };
        }
    }
}
