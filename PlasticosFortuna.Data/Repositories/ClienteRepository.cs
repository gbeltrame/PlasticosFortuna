using PlasticosFortuna.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PagedList.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PlasticosFortuna.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private AppDbContext _appDbContext;

        public ClienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public PagedList<Cliente> GetClientes(PaginationDTO pagination)
        {
            PagedList<Cliente> model = new PagedList<Cliente>(_appDbContext.Clientes, pagination.Page, pagination.PageSize);
            return model;
        }

        public Cliente GetClienteById(int clienteId)
        {
            return _appDbContext.Clientes.FirstOrDefault(c => c.Id == clienteId);   
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var foundCliente =  _appDbContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);

            if (foundCliente != null)
            {
                foundCliente.Nombre = cliente.Nombre;
                foundCliente.Descripcion = cliente.Descripcion;
                foundCliente.Email = cliente.Email;

                _appDbContext.SaveChanges();
                return foundCliente;
            }
            return null;
        }

        public void DeleteCliente(int clienteId)
        {
            var foundCliente = _appDbContext.Clientes.FirstOrDefault(c => c.Id == clienteId);
            if (foundCliente != null)
            {
                _appDbContext.Clientes.Remove(foundCliente);
                _appDbContext.SaveChanges();

            }

        }

        public Cliente AddCliente(Cliente cliente)
        {
            var addedEntity = _appDbContext.Clientes.Add(cliente);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }
    }
}