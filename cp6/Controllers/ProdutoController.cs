using Microsoft.AspNetCore.Mvc;
using cp6.Entities;
using cp6.Services;

namespace cp6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoService _service;

        public ProdutoController()
        {
            _service = new ProdutoService();
        }

        // GET api/produto
        [HttpGet]
        public IActionResult GetAll()
        {
            var produtos = _service.GetAll();
            return Ok(produtos);
        }

        // GET api/produto/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = _service.GetById(id);
            if (produto == null)
                return NotFound("Vinho não encontrado.");

            return Ok(produto);
        }

        // POST api/produto
        [HttpPost]
        public IActionResult Add([FromBody] Produto produto)
        {
            _service.Add(produto);
            return CreatedAtAction(nameof(GetById), new { id = produto.Id }, produto);
        }

        // PUT api/produto/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Produto produto)
        {
            var atualizado = _service.Update(id, produto);
            if (!atualizado)
                return NotFound("Vinho não encontrado para atualização.");

            return Ok("Vinho atualizado com sucesso!");
        }

        // DELETE api/produto/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var removido = _service.Delete(id);
            if (!removido)
                return NotFound("Vinho não encontrado para remoção.");

            return Ok("Vinho removido com sucesso!");
        }
    }
}
