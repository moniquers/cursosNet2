using CasaDoCodigo.Models;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationContext _context;

        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public List<Produto> GetProdutos()
        {
            return _context.Set<Produto>().ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            foreach (var livro in livros)
            {
                _context.Set<Produto>().Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
            }
            _context.SaveChanges();
        }

    }
}
