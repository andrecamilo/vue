using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web.Entidades
{
    public class Endereco
    {
        public Endereco(string endereco)
        {
            rua = "rua "+ endereco;
            cidade = "Curitiba";
            estado = "Parana";
        }


        public string rua { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}
