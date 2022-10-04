using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            if (name == null)
                return new Coffee("latte", -1);
            else
                return new Coffee(name, 2);
        }

        [HttpGet("lover")]
        public string GetSomeLove()
        {
            return "I like coffee!";
        }
    }
}
