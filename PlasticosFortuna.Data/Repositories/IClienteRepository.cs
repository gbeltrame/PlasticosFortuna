using PagedList.Core;
using PlasticosFortuna.Shared;
using System.Threading.Tasks;

namespace PlasticosFortuna.Data.Repositories
{
    public interface IClienteRepository
    {
        void DeleteCliente(int clienteId);
        Cliente GetClienteById(int clienteId);
        PagedList<Cliente> GetClientes(PaginationDTO pagination);
        Task<Cliente> UpdateCliente(Cliente cliente);
    }
}