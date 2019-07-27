using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservice00001TemplateAPI.DataAccessLayers;
using Microservice00001TemplateAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservice00001TemplateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class V1ActivityController : ControllerBase
    {
        private readonly IV1ActivityRepositories _v1activitiyrepo;
        // kong daghan data i return kay butanggan og list ang methods
        public V1ActivityController(IV1ActivityRepositories v1activitiyrepo)
        {
            _v1activitiyrepo = v1activitiyrepo;
        }

        [HttpGet("")]
        [Produces("application/json", Type = typeof(List<V1Activity>))]
        //public ActionResult<IEnumerable<string>> Get()
        // @todo: update and finalize the controller request public IActionResult Get() can be substitute
        //the GET using IAction
        //uncomment below to get the Select query with Parameter on it
        //public IActionResult Get([FromBody] V1Branch request)
        public async Task<ActionResult<List<V1Activity>>> GetAll()
        {
            var output = await _v1activitiyrepo.Get();
            return Ok(output);
        }

        /// <summary>
        /// Returns a group of Employees matching the given first and last names.
        /// </summary>
        /// <remarks>
        /// Here is a sample remarks placeholder.
        /// </remarks>
        /// <param name="firstName">The first name to search for</param>
        /// <param name="lastName">The last name to search for</param>
        /// <returns>A string status</returns>
        [HttpPost("", Name = "Post")]
        //public ActionResult<IEnumerable<string>> Get()
        // @todo: update and finalize the controller request public IActionResult Get() can be substitute
        //the GET using IAction
        //uncomment below to get the Select query with Parameter on it
        //public IActionResult Get([FromBody] V1Branch request)
        public async Task<ActionResult<V1Activity>> Post([FromBody]IIV1ActivityPost model)
        {
            var output = await _v1activitiyrepo.Post(model);
            return Ok(output);
        }
    }

}