using System;
using System.Collections.Generic;
using Fatec.Clinica.Dado;
using Fatec.Clinica.Dominio;
using Fatec.Clinica.Dominio.Dto;
using Fatec.Clinica.Dominio.Excecoes;

namespace Fatec.Clinica.Negocio
{
    public class UsuarioNegocio
    {
        private readonly UsuarioRepositorio _usuarioRepositorio;

        public UsuarioNegocio()
        {
            _usuarioRepositorio = new UsuarioRepositorio();
        }

        public int Inserir(Usuario entity)
        {
            //Verifica se os campos Email e Senha estão preenchidos
            if (String.IsNullOrEmpty(entity.Email) || String.IsNullOrEmpty(entity.Senha))
                throw new ConflitoException("Email ou senha não estão preenchidos !");

            var emailExistente = _usuarioRepositorio.SelecionarPorEmail(entity.Email);

            //Verifica se já existe um usuario com o Email já cadastrado
            if (emailExistente != null)
                throw new ConflitoException($"Já existe usuário cadastrado com Email {emailExistente.Email}!");

            return _usuarioRepositorio.Inserir(entity);
        }
    }
}
