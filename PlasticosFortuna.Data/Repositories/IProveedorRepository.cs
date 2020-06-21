using PlasticosFortuna.Shared;
using System;
using System.Threading.Tasks;

namespace PlasticosFortuna.Data.Repositories
{
    public interface IProveedorRepository
    {
        Proveedor AddProveedor(Proveedor Proveedor);
        void DeleteProveedor(int ProveedorId);
        Proveedor GetProveedorById(int ProveedorId);
        PagedList<Proveedor> GetProveedores(PaginationDTO pagination, String OrderBy, String OrderType);
        Task<Proveedor> UpdateProveedor(Proveedor Proveedor);
    }
}