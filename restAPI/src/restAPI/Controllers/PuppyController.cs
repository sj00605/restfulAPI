using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

using restAPI.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace restAPI.Controllers
{
    [Route("api/Puppy")]
    public class PuppyController : Controller
    {

        [FromServices]
        public IPuppyRepository Puppies { get; set; }

        // GET: puppy/values
        [HttpGet]
        public IEnumerable<Puppy> Get()
        {
            return Puppies.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}", Name = "GetPuppy")]
        public IActionResult GetById(int id)
        {
            var puppy = Puppies.Find(id);
            if (puppy == null)
            {
                return HttpNotFound();
            }
            return new ObjectResult(puppy);
        }

          // POST api/values
          [HttpPost]
          public IActionResult Post([FromBody] Puppy puppy)
          {
            if(puppy == null)
            {
                return HttpBadRequest();
            }

            Puppies.Add(puppy);
            return CreatedAtRoute("GetPuppy", new { controller = "Puppy", id = puppy.Id }, puppy);

          }

          // PUT api/values/5
          [HttpPut("{id}")]
          public IActionResult Put(int id, [FromBody]Puppy puppy)
          {

            Puppy oldPup = Puppies.Find(id);

             if (oldPup != null)
            {

                int oldId = oldPup.Id;
                puppy.Id = oldId;
                Puppies.Remove(oldId);
                Puppies.Update(puppy);
                return new NoContentResult();
            }
            else
            {
                return HttpBadRequest();
            }
          }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
              Puppies.Remove(id);
            }

    }
}
