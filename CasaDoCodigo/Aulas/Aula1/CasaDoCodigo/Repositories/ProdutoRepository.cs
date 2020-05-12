using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext context) : base(context)
        {
        }

        public List<Produto> GetProdutos()
        {
            return _dbSet.ToList();
        }

        public void SaveProdutos(List<Livro> livros)
        {
            //var livrosParaInserir = livros.Where(x => !_dbSet.Any(d => d.Codigo == x.Codigo));

            //if (livrosParaInserir.Any())
            //    _dbSet.AddRange(livrosParaInserir.Select(livro => new Produto(livro.Codigo, livro.Nome, livro.Preco)));

            foreach (var livro in livros)
            {
                if (!_dbSet.Where(p => p.Codigo == livro.Codigo).Any())
                {
                    _dbSet.Add(new Produto(livro.Codigo, livro.Nome, livro.Preco));
                }
            }
            _context.SaveChanges();
        }

    }
}
