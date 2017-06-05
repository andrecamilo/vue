using Microsoft.AspNetCore.Mvc;
using API.Web.Entidades;
using System.Collections.Generic;
using System.Net.Http;
using System.Net;
using System.Linq;
using System.Text;

namespace API.Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private List<Usuario> _lst;
        private List<Usuario> lst
        {
            get
            {
                _lst = new List<Usuario>();

                _lst.Add(new Usuario("Andre", "Camilo"));
                _lst.Add(new Usuario("Keila", "Ferreira"));
                _lst.Add(new Usuario("Daniel", "Camilo"));

                return _lst;
            }
        }



        // GET api/usuario
        [HttpGet]
        public JsonResult Get()
        {
            AddHeader();

            return Json(lst);
        }

        private void AddHeader()
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
            Response.Headers.Add("Access-Control-Allow-Methods", "GET,PUT,PATCH,POST,DELETE");
            Response.Headers.Add("Cache-Control", "no-cache");
        }

        // GET api/usuario/xxx
        [HttpGet("{nome}")]
        public string Get(string nome)
        {
            AddHeader();

            var lstUsuario = lst.Where(p => p.nome.Contains(nome));
            try
            {
                return lstUsuario.FirstOrDefault().nome + ' '+ lstUsuario.FirstOrDefault().sobrenome;
            }
            catch
            {
                return "Sem resultado";
            }
        }

        // POST api/usuario
        [HttpPost]
        public void Post([FromBody]Usuario usuario)
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
