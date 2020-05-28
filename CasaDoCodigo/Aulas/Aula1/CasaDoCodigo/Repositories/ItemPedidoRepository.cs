using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;
using System.Linq;

namespace CasaDoCodigo.Repositories
{
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(ApplicationContext context) : base(context)
        {
        }

        public ItemPedido GetItemPedido(int itemPedidoId)
        {
            return
            _dbSet
                .Where(ip => ip.Id == itemPedidoId)
                .SingleOrDefault();
        }
    }
}