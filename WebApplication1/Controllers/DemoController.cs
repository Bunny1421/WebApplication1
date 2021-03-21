using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        [Route("Name")]
        [HttpGet]
        public List<string> GetName(string name)
        {
            var list = new List<string>
            {
                "Nuchy",
                "A",
                "B",
                "C"
            };

            if (name == null)
            {
                return list;
            }

            var results = list.Where(list => list.Contains(name));
            return results.ToList();
        }
    }
}
