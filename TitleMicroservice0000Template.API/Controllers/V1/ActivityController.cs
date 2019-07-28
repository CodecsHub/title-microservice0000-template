using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TitleMicroservice0000Template.Domain.DTO.V1;
using TitleMicroservice0000Template.Domain.Entities.V1;
using TitleMicroservice0000Template.Domain.UseCase.V1;

namespace TitleMicroservice0000Template.API.Controllers.V1
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private IActivityDataAccess _activityDataAccess;

        public ActivityController(IActivityDataAccess activityDataAccess)
        {
            _activityDataAccess = activityDataAccess;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var models =  _activityDataAccess.GetAll();

            return Ok(models);
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    var model = _activityDataAccess.GetActivityBy(id);

        //    return Ok(model);
        //}

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Activity model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var activity = _activityDataAccess.Add(model);

            return CreatedAtAction("Get", new { id = activity.Id }, activity);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody]Activity model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _activityDataAccess.Update(id, model);

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            _activityDataAccess.Delete(id);
            return NoContent();
        }
    }
}
