﻿namespace Fatec.Clinica.Dominio
{
    public abstract class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public char Ativo { get; set; }
        public int IdUsuario { get; set; }
    }
}
