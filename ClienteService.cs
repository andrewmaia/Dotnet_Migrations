
namespace Dotnet_Migrations
{
    public class ClienteService
    {
        public readonly AppDbContext _dbContext;

        public ClienteService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AdicionarCliente(Cliente cliente)
        {
            await _dbContext.Clientes.AddAsync(cliente);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<Cliente>> SelecionarClientes()
        {
            return  _dbContext.Clientes.ToList();
        }        
    }
}