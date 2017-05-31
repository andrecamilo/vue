using Microsoft.AspNetCore.Mvc;
using API.Web.Entidades;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Text;

namespace API.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        // GET api/usuario
        [HttpGet]
        public JsonResult Get()
        {
            var lst = new List<Usuario>();
            lst.Add(new Usuario("Andre"));
            lst.Add(new Usuario("Keila"));
            lst.Add(new Usuario("Daniel"));

            //Response.Headers.Add("access-control-allow-credentials", "true");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET,PUT,PATCH,POST,DELETE");
            Response.Headers.Add("Cache-Control", "no-cache");

            return Json(lst);
        }

        // GET api/usuario/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/usuario
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/usuario/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/usuario/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
