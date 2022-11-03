using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dio_livraria_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dio_livraria_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrariaController : ControllerBase
    {
        private readonly TodoContext _context;

        public LivrariaController(TodoContext context)
        {
            _context = context;

            _context.todoProdutos.Add(new Produto { Id = 1, Nome = "Game of Thrones Vol. 1", Preco = 49.90, Quantidade = 3, Categoria = "Acao", Imagem = "got-vol1" });
            _context.todoProdutos.Add(new Produto { Id = 2, Nome = "Game of Thrones Vol. 2", Preco = 49.90, Quantidade = 5, Categoria = "Acao", Imagem = "got-vol2" });
            _context.todoProdutos.Add(new Produto { Id = 3, Nome = "Game of Thrones Vol. 3", Preco = 49.90, Quantidade = 2, Categoria = "Acao", Imagem = "got-vol3" });
            _context.todoProdutos.Add(new Produto { Id = 4, Nome = "Game of Thrones Vol. 4", Preco = 49.90, Quantidade = 12, Categoria = "Acao", Imagem = "got-vol4" });
            _context.todoProdutos.Add(new Produto { Id = 5, Nome = "Game of Thrones Vol. 5", Preco = 49.90, Quantidade = 2, Categoria = "Acao", Imagem = "got-vol5" });

            _context.SaveChanges();
        }

        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            _context.todoProdutos.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.todoProdutos.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> GetItem(int id)
        {
            var item = await _context.todoProdutos.FindAsync(id);

            if (item == null) return NotFound();

            return item;
        }





    }
}