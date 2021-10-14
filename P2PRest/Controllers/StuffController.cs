using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleP2PRest.Managers;
using SimpleP2PRest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleP2PRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StuffController : ControllerBase
    {
        private readonly StuffManager _manager = new StuffManager();


        [HttpGet]
        public IEnumerable<Stuff> Get()
        {
            return _manager.GetAll();
        }


        [HttpGet("{name}")]
        public List<Stuff> Get(string name)
        {
            return _manager.GetByName(name);
        }


        [HttpPost]
        public Stuff Post([FromBody] Stuff value)
        {
            return _manager.Add(value);
        }


        [HttpPut("{name}")]
        public Stuff Put(string name, [FromBody] Stuff value)
        {
            return _manager.Update(name, value);
        }


        [HttpDelete("{name}")]
        public Stuff Delete(string name)
        {
            return _manager.Delete(name);
        }
    }
}
