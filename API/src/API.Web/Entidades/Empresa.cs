using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web.Entidades
{
    public class Empresa
    {
        public Empresa(string nome)
        {
            RazaoSocial = nome+" LTDA";
            NomeFantasia = nome+"LTDA";
            Email = nome+"@"+ nome + ".com";
        }

        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Email { get; set; }
    }
}
