using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlasticosFortuna.Data.Repositories;
using PlasticosFortuna.Shared;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PlasticosFortuna.Api.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;


        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet]
        public IActionResult GetAllClientes([FromQuery]int page, [FromQuery]int pageSize)
        {
            try
            {
                PaginationDTO paging = new PaginationDTO { Page = page, PageSize = pageSize };
                return Ok(_clienteRepository.GetClientes(paging));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id)
        {
            try
            {
                return Ok(_clienteRepository.GetClienteById(id));
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult CreateCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest();

                if (cliente.Nombre == string.Empty)
                {
                    ModelState.AddModelError("Nombre", "El campo 'Nombre' no puede estar vacio");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var createdCliente = _clienteRepository.AddCliente(cliente);

                return Created("cliente", createdCliente);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult UpdateCliente([FromBody] Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return BadRequest();

                if (cliente.Nombre == string.Empty)
                {
                    ModelState.AddModelError("Nombre", "El campo 'Nombre' no puede estar vacio");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var employeeToUpdate = _clienteRepository.UpdateCliente(cliente);

                if (employeeToUpdate == null)
                    return NotFound("El cliente no existe");

                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest();

                var employeeToDelete = _clienteRepository.GetClienteById(id);
                if (employeeToDelete == null)
                    return NotFound();

                _clienteRepository.DeleteCliente(id);

                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

    }
}
