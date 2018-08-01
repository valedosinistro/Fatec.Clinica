using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Fatec.Clinica.Dado.Abstracao;
using Fatec.Clinica.Dado.Configuracao;
using Fatec.Clinica.Dominio;

namespace Fatec.Clinica.Dado
{
    public class UsuarioRepositorio : IRepositorioBase<Usuario>
    {
        public void Alterar(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new System.NotImplementedException();
        }

        public int Inserir(Usuario entity)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                return connection.QuerySingle<int>($"DECLARE @ID int;" +
                                              $"INSERT INTO [Usuario] " +
                                              $"(Email,Senha,Tipo,Ativo) " +
                                                    $"VALUES (" +
                                                    $"'{entity.Email}'," +
                                                    $"'{entity.Senha}'," +
                                                    $"'{entity.Tipo}'," +
                                                    $"'{entity.Ativo}')" +
                                              $"SET @ID = SCOPE_IDENTITY();" +
                                              $"SELECT @ID");
            }
               
        }

        public IEnumerable<Usuario> Selecionar()
        {
            throw new System.NotImplementedException();
        }

        public Usuario SelecionarPorId(int id)
        {
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public Usuario SelecionarPorEmail(string email)
        {
            using (var connection = new SqlConnection(DbConnectionFactory.SQLConnectionString))
            {
                var obj = connection.QueryFirstOrDefault<Usuario>($"SELECT * " +
                                                                 $"FROM [Usuario] " +
                                                                 $"WHERE Email = '{email}'");
                return obj;
            }
        }
    }
}
