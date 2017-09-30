using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WearManager.Context;
using WearManager.Models;

namespace WearManager.Controllers
{
    [Route("api/[controller]")]
    public class BikeController : Controller
    {
        private MainContext _dbContext;

        public BikeController()
        {
            _dbContext = new MainContext();
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Bike> Get()
        {
            return _dbContext.Bikes.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Bike Get(int id)
        {
            return _dbContext.Bikes.Where(x => x.Id == id).First();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Bike value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Bike value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
