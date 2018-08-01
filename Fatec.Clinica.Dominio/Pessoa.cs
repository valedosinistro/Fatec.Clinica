using System;

namespace Fatec.Clinica.Dominio
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Boolean Ativo { get; set; }
        public int IdUsuario { get; set; }
    }
}
