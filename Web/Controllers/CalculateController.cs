using Microsoft.AspNetCore.Mvc;
using Domain;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculateController : ControllerBase
    {
        [HttpGet("Add/{left}/{right}")]
        public int Get(int left, int right)
        {
            return new Calculator().Sum(left, right);
        }
    }
}