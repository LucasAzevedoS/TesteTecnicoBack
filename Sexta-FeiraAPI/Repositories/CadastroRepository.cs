using System.Data.SqlClient;
using API.Models;
using API.Services.InputModels;
using Dapper;
using Barber.Services;
using System.Data;

namespace API.Repositories



{
    public class CadastroRepository
    {
        UtilService _utilService = new UtilService();


        public int? IncluiUsuario(string nome, string email, string senhaHash)
        {
            string query = $"exec stp_incluiUsuario @Nome, @Email, @SenhaHash";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();

                return conn.Query<int>(query, new
                {
                    Nome = nome,
                    Email = email,
                    SenhaHash = senhaHash
                }).FirstOrDefault();
            }
        }

        public Usuario? SelecionaPorEmail(string email)
        {
            string query = $"exec stp_selUsuarioEmail @Email";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();

                return conn.Query<Usuario>(query, new { Email = email })
                           .FirstOrDefault();
            }
        }


        public int? IncluiPessoa(IncluiPessoaInputModel pessoa)
        {
            string query = $"exec stp_incluiPessoa @Nome, @Idade";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();
                return conn.Query<int>(query, new
                {
                    Nome = pessoa.Nome,
                    Idade = pessoa.Idade,
                }).FirstOrDefault();
            }
        }



        public int? IncluiCategoria(IncluiCategoriaInputModel categoria)
        {
            string query = $"exec stp_incluiCategoria @Descricao, @Finalidade";
            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();
                return conn.Query<int>(query, new
                {
                    Descricao = categoria.Descricao,
                    Finalidade = categoria.Finalidade,
                }).FirstOrDefault();
            }
        }

        public int? IncluiTransacao(IncluiTransacaoInputModel transacao)
        {
            string query = $"exec stp_incluiTransacao @Descricao, @Valor, @Tipo, @PessoaId, @CategoriaId";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();

                return conn.Query<int>(query, new
                {
                    Descricao = transacao.Descricao,
                    Valor = transacao.Valor,
                    Tipo = transacao.Tipo,
                    PessoaId = transacao.PessoaId,
                    CategoriaId = transacao.CategoriaId
                }).FirstOrDefault();
            }
        }


        public List<Pessoa> SelectPessoa()
        {
            string query = "exec stp_selPessoa";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                return conn.Query<Pessoa>(query).ToList();
            }
        }

        public List<Categoria> SelectCategoria()
        {
            string query = "exec stp_selCategoria";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                return conn.Query<Categoria>(query).ToList();
            }
        }


        public Pessoa? SelectPessoaId(int id)
        {
            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                return conn.QueryFirstOrDefault<Pessoa>(
                    "stp_selPessoaId",
                    new { Id = id },
                    commandType: CommandType.StoredProcedure
                );
            }
        }

        public Categoria? SelectCategoriaId(int id)
        {
            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                return conn.QueryFirstOrDefault<Categoria>(
                    "stp_selCategoriaId",
                    new { Id = id },
                    commandType: CommandType.StoredProcedure
                );
            }
        }
        public List<TransacaoListaModel> SelectTransacao()
        {
            string query = $"exec stp_selTransacao";

            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();

                return conn.Query<TransacaoListaModel>(query).ToList();
            }
        }













        public List<Pessoa> SelectPessoaGrupo(int id)
        {
            string query = $"exec stp_selPessoaGrupo {id}";
            {
                using (var conn = new SqlConnection(_utilService.SeviceConn()))
                {
                    return conn.Query<Pessoa>(query).ToList();
                }
            }


        }

        public int? InativarGrupo(int id)
        {
            string query = "EXEC stp_inativarGrupo @id";
            using (var conn = new SqlConnection(_utilService.SeviceConn()))
            {
                conn.Open();
                return conn.Query<int>(query, new { id }).FirstOrDefault();
            }
        }

    }
}