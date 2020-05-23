using PagedList.Core;
using PlasticosFortuna.Shared;
using System.Threading.Tasks;

namespace PlasticosFortuna.Data.Repositories
{
    public interface IProveedorRepository
    {
        Proveedor AddProveedor(Proveedor Proveedor);
        void DeleteProveedor(int ProveedorId);
        Proveedor GetProveedorById(int ProveedorId);
        PagedList<Proveedor> GetProveedores(PaginationDTO pagination);
        Task<Proveedor> UpdateProveedor(Proveedor Proveedor);
    }
}