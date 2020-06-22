using PlasticosFortuna.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace PlasticosFortuna.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private AppDbContext _appDbContext;

        public ClienteRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public PagedList<Cliente> GetClientes(PaginationDTO pagination, String OrderBy, String OrderType, String Searchfilter)
        {
            IQueryable<Cliente> filteredClientes;
            if(Searchfilter != null)
            {
                filteredClientes = _appDbContext.Clientes.Where(a => a.Id.ToString().Contains(Searchfilter) || a.Nombre.Contains(Searchfilter) || a.Descripcion.Contains(Searchfilter) || a.Email.Contains(Searchfilter));
            }
            else
            {
                filteredClientes = _appDbContext.Clientes;
            }

            switch (OrderBy)
            {
                case "Id":
                    if (OrderType == "desc")
                    {

                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderByDescending((o => o.Id)), pagination.PageNumber, pagination.PageSize);
                    }
                    else
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderBy((o => o.Id)), pagination.PageNumber, pagination.PageSize);
                    }
                case "Nombre":
                    if (OrderType == "desc")
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderByDescending((o => o.Nombre)), pagination.PageNumber, pagination.PageSize);
                    }
                    else
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderBy((o => o.Nombre)), pagination.PageNumber, pagination.PageSize);
                    }
                case "Descripcion":
                    if (OrderType == "desc")
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderByDescending((o => o.Descripcion)), pagination.PageNumber, pagination.PageSize);
                    }
                    else
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderBy((o => o.Descripcion)), pagination.PageNumber, pagination.PageSize);
                    }
                case "Email":
                    if (OrderType == "desc")
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderByDescending((o => o.Email)), pagination.PageNumber, pagination.PageSize);
                    }
                    else
                    {
                        return PagedList<Cliente>.ToPagedList(filteredClientes.OrderBy((o => o.Email)), pagination.PageNumber, pagination.PageSize);
                    }
                default:
                    return PagedList<Cliente>.ToPagedList(filteredClientes, pagination.PageNumber, pagination.PageSize);
            }

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