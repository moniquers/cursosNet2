using CasaDoCodigo.Models;
using Microsoft.AspNetCore.Http;

namespace CasaDoCodigo.Repositories
{
    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public PedidoRepository(ApplicationContext context, IHttpContextAccessor httpContextAccessor) : base(context)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private int? GetPedidoId()
        {
            var pedidoId = _httpContextAccessor.HttpContext.Session.GetInt32("pedidoId");
            return pedidoId;
        }

        private void SetPedidoId(int pedidoId)
        {
            _httpContextAccessor.HttpContext.Session.SetInt32("pedidoId", pedidoId);
        }

    }
}
