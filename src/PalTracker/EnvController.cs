using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("env")]
    public class EnvController : ControllerBase
    {
        private readonly CloudFoundryInfo _message;

        [HttpGet]
        public CloudFoundryInfo Get() => _message;

        public EnvController(CloudFoundryInfo message)
        {
            _message = message;
        }
    }
}