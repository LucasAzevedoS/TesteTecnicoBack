

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
        [HttpPost("incluiPessoa")]
        public int? incluiPessoa(IncluiPessoaInputModel pessoa)
        {
            return _cadastroService.IncluiPessoa(pessoa);


        }





        [HttpPatch("inativarGrupo/{id}")]
        public IActionResult InativarGrupo(int id)
        {
            try
            {
                var grupo = _cadastroService.InativarGrupo(id);

                if (grupo == null)
                {
                    return NotFound("Grupo não encontrado.");
                }

                return Ok(grupo);
            }
            catch (Exception ex)
            {
                // Aqui você pode logar o erro se quiser
                return StatusCode(500, $"Erro ao inativar o grupo: {ex.Message}");
            }
        }


        [HttpGet("SelPessoa")]
        public List<Pessoa> SelectPessoa()
        {
            return _cadastroService.selectPessoa();
        }


        [HttpGet("SelPessoaporID/{id}")]
        public Pessoa? SelectPessoa(int id)
        {
            return _cadastroService.selectPessoaId(id);
        }










    }
}