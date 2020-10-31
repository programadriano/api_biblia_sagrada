using Api.Entidades;
using Api.Entidades.Enums;
using Api.Entidades.Servicos;
using Api.Infra;
using Api.Models;
using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Servicos
{
    public class LivroService : ILivroService
    {
        private readonly string _connectionString;


        public LivroService(IOptions<Configuracoes> settings)
        {
            _connectionString = settings.Value.ConnectionString;

        }

        public IEnumerable<Capitulos> BuscarCapitulos(int livroId)
        {
            var conexao = new SqlConnection(_connectionString);
            conexao.Open();
            var query = $@"select Sigla, Capitulos as 'Quantidade' from Livro where id = {livroId}";
            var capitulos = conexao.Query<Capitulos>(query).ToList();
            conexao.Close();

            return capitulos;
        }

        public IEnumerable<Livro> BuscarTodosLivros(int page, int qtd, Testamento testamento)
        {
            var conexao = new SqlConnection(_connectionString);
            conexao.Open();
            var query = "";

            if (testamento == Testamento.NovoEVelho)
            {
                query = $@"SELECT * FROM [db_blible_dev].[dbo].[Livro]  order by id OFFSET {page * qtd} ROWS FETCH NEXT {qtd} ROWS ONLY";
            }
            else
            {
                query = $@"SELECT * FROM [db_blible_dev].[dbo].[Livro] where Testamento = {(int)testamento}  order by id OFFSET {page * qtd} ROWS FETCH NEXT {qtd} ROWS ONLY";
            }

            var livros = conexao.Query<Livro>(query).ToList();
            conexao.Close();

            return livros;
        }
    }
}
