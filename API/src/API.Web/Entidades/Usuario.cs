﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web.Entidades
{
    public class Usuario
    {
        public Usuario(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.email = nome.ToLower().Trim()+"@tce.com";
            this.telefone = "99 9999-9999";
            this.empresa = new Empresa(nome);
            this.endereco = new Endereco(nome);
        }

        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public Empresa empresa { get; set; }
        public Endereco endereco { get; set; }
        public string localizacao { get { return endereco.rua + " - " + endereco.cidade + " - " + endereco.estado; } }
    }
}
