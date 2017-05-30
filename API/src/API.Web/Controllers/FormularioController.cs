using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ETC.Vue.Web.Entidades;

namespace API.Web.Controllers
{
    [Route("api/[controller]")]
    public class FormularioController : Controller
    {
        // GET api/values
        [HttpGet]
        public Formulario Get()
        {
            var form = new Formulario();
            var tipos = new List<Tipo>();
            var comentarios = new List<Comentario>();
            tipos.Add(new Tipo() { Id = 1, Nome = "teste" });
            comentarios.Add(new Comentario() { Id = 1, Descricao = "teste" });

            form.Tipos = tipos;
            form.Comentarios = comentarios;

            return form;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
