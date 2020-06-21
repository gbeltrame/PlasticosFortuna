using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlasticosFortuna.Data.Repositories;
using PlasticosFortuna.Shared;
using Newtonsoft.Json;

namespace PlasticosFortuna.Api.Controllers
{
    [ApiController]
    [Route("api/proveedores")]
    public class ProveedorController : ControllerBase
    {
        private readonly IProveedorRepository _ProveedorRepository;

        public ProveedorController(IProveedorRepository ProveedorRepository)
        {
            _ProveedorRepository = ProveedorRepository;
        }

        [HttpGet]
        public IActionResult GetAllProveedores([FromQuery] PaginationDTO paging, [FromQuery] String orderby, [FromQuery] String ordertype)
        {
            try
            {
                var proveedores = _ProveedorRepository.GetProveedores(paging, orderby, ordertype);
                var metadata = new
                {
                    proveedores.TotalCount,
                    proveedores.PageSize,
                    proveedores.CurrentPage,
                    proveedores.TotalPages,
                    proveedores.HasNext,
                    proveedores.HasPrevious
                };
                Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
                return Ok(proveedores);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProveedorById(int id)
        {
            return Ok(_ProveedorRepository.GetProveedorById(id));
        }

        [HttpPost]
        public IActionResult CreateProveedor([FromBody] Proveedor Proveedor)
        {
            try
            {
                if (Proveedor == null)
                    return BadRequest();

                if (Proveedor.Nombre == string.Empty)
                {
                    ModelState.AddModelError("Nombre", "El campo 'Nombre' no puede estar vacio");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var createdProveedor = _ProveedorRepository.AddProveedor(Proveedor);

                return Created("Proveedor", createdProveedor);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult UpdateProveedor([FromBody] Proveedor Proveedor)
        {
            try
            {
                if (Proveedor == null)
                    return BadRequest();

                if (Proveedor.Nombre == string.Empty)
                {
                    ModelState.AddModelError("Nombre", "El campo 'Nombre' no puede estar vacio");
                }

                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var employeeToUpdate = _ProveedorRepository.UpdateProveedor(Proveedor);

                if (employeeToUpdate == null)
                    return NotFound("El Proveedor no existe");

                return NoContent();
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProveedor(int id)
        {
            try
            {
                if (id <= 0)
                    return BadRequest();

                var employeeToDelete = _ProveedorRepository.GetProveedorById(id);
                if (employeeToDelete == null)
                    return NotFound();

                _ProveedorRepository.DeleteProveedor(id);

                return NoContent();//success
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
