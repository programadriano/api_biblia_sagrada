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

        public IEnumerable<Verso> BuscarVersosPorSiglaCapituloEVersiculo(string sigla, int capitulo, int versiculo)
        {
            var conexao = new SqlConnection(_connectionString);
            conexao.Open();
            var query = $@"select v.Versiculo, v.Texto from Livro l inner join Versos v on v.LivroId = l.Id where l.Sigla = '{sigla}' and Capitulo = {capitulo} and v.Versiculo = {versiculo}";

            var livros = conexao.Query<Verso>(query).ToList();
            conexao.Close();

            return livros;
        }

        public IEnumerable<Verso> BuscarVersosPorSiglaECapitulo(string sigla, int capitulo)
        {
            var conexao = new SqlConnection(_connectionString);
            conexao.Open();
            var query = $@"select v.Versiculo, v.Texto from Livro l inner join Versos v on v.LivroId = l.Id where l.Sigla = '{sigla}' and v.Capitulo = {capitulo}";

            var livros = conexao.Query<Verso>(query).ToList();
            conexao.Close();

            return livros;
        }

        public IEnumerable<Livro> ListarLivros()
        {
            var conexao = new SqlConnection(_connectionString);
            conexao.Open();
            var query = "SELECT Capitulos,Nome,Sigla,Testamento FROM Livro";

            var livros = conexao.Query<Livro>(query).ToList();
            conexao.Close();

            return livros;
        }
    }
}
