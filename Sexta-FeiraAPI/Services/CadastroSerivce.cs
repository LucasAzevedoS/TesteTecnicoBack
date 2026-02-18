using System.Text.RegularExpressions;
using API.Models;
using API.Repositories;
using API.Services.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
    public class CadastroSerivce
    {
        CadastroRepository _pessoaRepository = new CadastroRepository();

        public int? CadastroUsuario(CadastroUsuarioInputModel model)
        {
            var senhaHash = GerarHash(model.Senha);

            return _pessoaRepository.IncluiUsuario(
                model.Nome,
                model.Email,
                senhaHash
            );
        }

        public object Login(LoginInputModel model)
        {
            var usuario = _pessoaRepository.SelecionaPorEmail(model.Email);

            if (usuario == null)
                throw new Exception("Usuário não encontrado");

            var senhaHash = GerarHash(model.Senha);

            if (usuario.SenhaHash != senhaHash)
                throw new Exception("Senha inválida");

            return new
            {
                usuario.Id,
                usuario.Nome,
                usuario.Email
            };
        }


        public int? IncluiPessoa(IncluiPessoaInputModel pessoa)
        {
            return _pessoaRepository.IncluiPessoa(pessoa);
        }

        public int? IncluiCategoria(IncluiCategoriaInputModel categoria)
        {
            return _pessoaRepository.IncluiCategoria(categoria);
        }

        public int? IncluiTransacao(IncluiTransacaoInputModel transacao)
        {
            var pessoa = _pessoaRepository.SelectPessoaId(transacao.PessoaId);

            if (pessoa == null)
                throw new Exception("Pessoa não encontrada");

            if (pessoa.Idade < 18 && transacao.Tipo.ToUpper() == "RECEITA")
                throw new Exception("Menor de idade não pode lançar RECEITA");

            var categoria = _pessoaRepository.SelectCategoriaId(transacao.CategoriaId);

            if (categoria == null)
                throw new Exception("Categoria não encontrada");

            if (categoria.Finalidade.ToUpper() != "AMBAS" &&
                categoria.Finalidade.ToUpper() != transacao.Tipo.ToUpper())
            {
                throw new Exception("Tipo da transação incompatível com a categoria");
            }


            return _pessoaRepository.IncluiTransacao(transacao);
        }


        public List<TransacaoListaModel> SelectTransacao()
        {
            return _pessoaRepository.SelectTransacao();
        }


        public List<Pessoa> selectPessoa()
        {
            return _pessoaRepository.SelectPessoa();
        }

        public List<Categoria>? selectCategoria()
        {
            return _pessoaRepository.SelectCategoria();
        }


        public Pessoa? selectPessoaId(int id)
        {
            return _pessoaRepository.SelectPessoaId(id);
        }

        public Categoria? selectCategoriaId(int id)
        {
            return _pessoaRepository.SelectCategoriaId(id);
        }

        public string GerarHash(string senha)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var bytes = System.Text.Encoding.UTF8.GetBytes(senha);
                var hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }



    }
}