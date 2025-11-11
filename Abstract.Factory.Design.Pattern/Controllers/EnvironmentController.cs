using Abstract.Factory.Design.Pattern.AbstractFactory;
using Abstract.Factory.Design.Pattern.ConcreteFactory;
using Microsoft.AspNetCore.Mvc;

namespace Abstract.Factory.Design.Pattern.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnvironmentController : ControllerBase
    {
        [HttpGet("{env}")]
        public IActionResult GetData(string env)
        {
            IEnvironmentFactory factory = env.ToLower() switch
            {
                "cloud" => new CloudEnvironmentFactory(),
                "onprem" => new OnPremiseEnvironmentFactory(),
                _ => throw new ArgumentException("Invalid environment")
            };

            var repo = factory.CreateRepository();
            var logger = factory.CreateLogger();

            logger.Log("Fetching data...");
            return Ok(repo.GetData());
        }
    }

}
