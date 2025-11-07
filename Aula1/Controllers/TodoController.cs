using Microsoft.AspNetCore.Mvc;

namespace Aula1.Controllers
{
    public class TodoController : ControllerBase
    {
        // GET: api/todo
        [Route("api/todo")]
        public IActionResult GetTodos() // Retorne TODAS as TODOS
        {
            return Ok(new[] { "Comprar Ovo", "Comprar Leite", "Dar Remédio pra Doguinha" });
        }

        // GET: api/todo
        [Route("api/todo/{id}")]
        public IActionResult GetById(int id) // Retorne TODAS as TODOS
        {
            return Ok(new[] { "Comprar Ovo", "Comprar Leite", "Dar Remédio pra Doguinha" });
        }
    }
}
