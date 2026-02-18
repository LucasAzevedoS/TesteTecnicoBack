

using API.Models;
using API.Services;
using API.Services.InputModels;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CadastroController : ControllerBase
    {
        CadastroSerivce _cadastroService = new CadastroSerivce();

        [HttpPost("cadastro")]
        public int? Cadastro(CadastroUsuarioInputModel model)
        {
            return _cadastroService.CadastroUsuario(model);
        }

        [HttpPost("login")]
        public object Login(LoginInputModel model)
        {
            return _cadastroService.Login(model);
        }

        [HttpPost("incluiPessoa")]
        public int? incluiPessoa(IncluiPessoaInputModel pessoa)
        {
            return _cadastroService.IncluiPessoa(pessoa);


        }

        [HttpPost("incluiCategoria")]
        public int? incluirCategoria(IncluiCategoriaInputModel categoria)
        {
            return _cadastroService.IncluiCategoria(categoria);


        }

        [HttpPost("incluiTransacao")]
        public int? IncluiTransacao(IncluiTransacaoInputModel transacao)
        {
            return _cadastroService.IncluiTransacao(transacao);
        }

        [HttpGet("SelPessoa")]
        public List<Pessoa> SelectPessoa()
        {
            return _cadastroService.selectPessoa();
        }

        [HttpGet("SelCategoria")]
        public List<Categoria> SelecCategoria()
        {
            return _cadastroService.selectCategoria();
        }

        [HttpGet("selTransacao")]
        public List<TransacaoListaModel> SelectTransacao()
        {
            return _cadastroService.SelectTransacao();
        }


        [HttpGet("SelPessoaporID/{id}")]
        public Pessoa? SelectPessoa(int id)
        {
            return _cadastroService.selectPessoaId(id);
        }

        [HttpGet("SelCategoriaID/{id}")]
        public Categoria? SelectCategoria(int id)
        {
            return _cadastroService.selectCategoriaId(id);
        }
    }
}