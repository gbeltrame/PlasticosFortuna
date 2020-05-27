using Microsoft.EntityFrameworkCore;
using PlasticosFortuna.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlasticosFortuna.Data.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private AppDbContext _appDbContext;

        public ProveedorRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public PagedList<Proveedor> GetProveedores(PaginationDTO pagination)
        {
            return PagedList<Proveedor>.ToPagedList(_appDbContext.Proveedores, pagination.PageNumber, pagination.PageSize);
        }

        public Proveedor GetProveedorById(int ProveedorId)
        {
            return _appDbContext.Proveedores.FirstOrDefault(c => c.Id == ProveedorId);
        }

        public async Task<Proveedor> UpdateProveedor(Proveedor Proveedor)
        {
            var foundProveedor = await _appDbContext.Proveedores.FirstOrDefaultAsync(c => c.Id == Proveedor.Id);

            if (foundProveedor != null)
            {
                foundProveedor.Nombre = Proveedor.Nombre;
                foundProveedor.Descripcion = Proveedor.Descripcion;
                foundProveedor.Email = Proveedor.Email;

                await _appDbContext.SaveChangesAsync();
            }
            return null;
        }

        public async void DeleteProveedor(int ProveedorId)
        {
            var foundProveedor = _appDbContext.Proveedores.FirstOrDefault(c => c.Id == ProveedorId);
            if (foundProveedor != null)
            {
                _appDbContext.Proveedores.Remove(foundProveedor);
                await _appDbContext.SaveChangesAsync();

            }

        }

        public Proveedor AddProveedor(Proveedor Proveedor)
        {
            var addedEntity = _appDbContext.Proveedores.Add(Proveedor);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }
    }
}
