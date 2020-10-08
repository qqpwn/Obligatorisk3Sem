using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Obligatorisk_opgave1;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FanOutPutController : ControllerBase
    {
        private static readonly List<FanOutput> FanoutputItems = new List<FanOutput>()
        {
            new FanOutput(0,"Output1", 20, 65),
            new FanOutput(1,"Output2", 15, 78),
            new FanOutput(2,"Output3", 24, 34),
            new FanOutput(3,"Output4", 19, 55),
            new FanOutput(4,"Output5", 21, 49),
        };

        // GET: api/<FanOutPutController>
        [HttpGet]
        public IEnumerable<FanOutput> Get()
        {
            return FanoutputItems;
        }

        // GET api/<FanOutPutController>/5
        [HttpGet("{id}")]
        public FanOutput Get(int id)
        {
            return FanoutputItems.Find(i => i.Id == id);
        }

        // POST api/<FanOutPutController>
        [HttpPost]
        public void Post([FromBody] FanOutput value)
        {
            FanoutputItems.Add(value);
        }

        // PUT api/<FanOutPutController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] FanOutput value)
        {
            FanOutput fanPut = Get(id);
            if (fanPut != null)
            {
                fanPut.Id = value.Id;
                fanPut.Name = value.Name;
                fanPut.Temp = value.Temp;
                fanPut.Fugt = value.Fugt;
            }
        }

        // DELETE api/<FanOutPutController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            FanOutput fanDelete = Get(id);
            FanoutputItems.Remove(fanDelete);
        }
    }
}
