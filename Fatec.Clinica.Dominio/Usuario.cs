using System;
using System.Collections.Generic;
using System.Text;

namespace Fatec.Clinica.Dominio
{
    public class Usuario
    {
        public int Id  { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public char Tipo { get; set; }
        public char Ativo { get; set; }
    }
}
