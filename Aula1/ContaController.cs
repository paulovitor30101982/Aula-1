using Microsoft.AspNetCore.Mvc;

namespace Aula1
{
    public class ContaController : ControllerBase
    {
        // Qual a Rota que essa Action responde?
        [Route("/saldo/{cpf}")]
        public IActionResult GetSaldo(string cpf)
        {
            if (cpf == "12345678900")
            {
                return Ok("Saldo: R$ 1.000,00");
            }
            else
            {
                return Ok("Saldo: R$ 0,00");
            }
        }
    }
}
