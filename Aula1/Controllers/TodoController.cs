using Microsoft.AspNetCore.Mvc;

namespace Aula1.Controllers
{
    public class TodoController : ControllerBase
    {
        [Route("/api/CadastroPecas")]
        public IActionResult CadastroPecas()
        {
            return Ok("Digite o Código da Peça: ");
        }

        [Route("/api/CadastroClientes")]
        public IActionResult CadastroCliente()
        {
            return Ok("Digite o CPF do Cliente: ");
        }
        [Route("/api/CadastroFornecedor")]
        public IActionResult CadastroFornecedor()
        {
            return Ok("Digite o CNPJ/CPF do Fornecedor: ");
        }
    }
}
