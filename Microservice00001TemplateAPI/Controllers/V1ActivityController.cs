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

        public V1ActivityController(IV1ActivityRepositories v1activitiyrepo)
        {
            _v1activitiyrepo = v1activitiyrepo;
        }

        [HttpGet("")]
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
    }

}