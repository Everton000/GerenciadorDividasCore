using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDividasCore.Services;
using GerenciadorDividasCore.Models.Serialize;

namespace GerenciadorDividasCore.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ISClienteService _service;

        public ClienteController(ISClienteService service)
        {
            _service = service;
        }

        // GET api/Cliente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            var items = await _service.GetClientesAsync();
            return Ok(items); //200
        }
    }
}
