using PlasticosFortuna.Shared;
using System.Threading.Tasks;

namespace PlasticosFortuna.Data.Repositories
{
    public interface IClienteRepository
    {
        void DeleteCliente(int clienteId);
        Cliente GetClienteById(int clienteId);
        PagedList<Cliente> GetClientes(PaginationDTO pagination);
        Cliente UpdateCliente(Cliente cliente);
        Cliente AddCliente(Cliente cliente);
    }
}