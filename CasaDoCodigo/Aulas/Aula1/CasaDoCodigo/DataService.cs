using Microsoft.EntityFrameworkCore;

namespace CasaDoCodigo
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext _context;

        public DataService(ApplicationContext context)
        {
            this._context = context;
        }

        public void InicializaDB()
        {
            _context.Database.Migrate();
        }
    }
}
