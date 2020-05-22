using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlasticosFortuna.Data.Repositories;
using PlasticosFortuna.Shared;

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
            PaginationDTO paging = new PaginationDTO { Page = page, PageSize = pageSize };
            return Ok(_clienteRepository.GetClientes(paging));
        }

        [HttpGet("{id}")]
        public IActionResult GetClienteById(int id)
        {
            return Ok(_clienteRepository.GetClienteById(id));
        }

    }
}
