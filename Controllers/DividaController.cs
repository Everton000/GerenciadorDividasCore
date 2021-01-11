using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GerenciadorDividasCore.Models;
using GerenciadorDividasCore.Services;

namespace GerenciadorDividasCore.Controllers
{
    [Route("api/dividas")]
    [ApiController]
    public class DividaController : ControllerBase
    {
        private readonly ISDividaService _service;

        public DividaController(ISDividaService service)
        {
            _service = service;
        }

        // GET api/divida
        [HttpGet]
        public ActionResult<IList<Divida>> Get()
        {
            var items = _service.GetAllDividas();
            return Ok(items); //200
        }

        // GET api/divida?clienteId=3
        [HttpGet("clienteId=clienteId")]
        public ActionResult<IList<Divida>> GetByCliente([FromQuery] int clienteId)
        {
            var items = _service.GetByCliente(clienteId);
            return Ok(items); //200
        }

        // GET api/divida/5
        [HttpGet("{id}")]
        public ActionResult<Divida> GetById(int id)
        {
            var item = _service.GetById(id);
            if (item == null)
            {
                return NotFound(); //404
            }
            return Ok(item); //200
        }

        // POST api/divida
        [HttpPost]
        public ActionResult Post([FromBody] Divida divida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400
            }
            var item = _service.Add(divida);
            return CreatedAtAction("Get", new { id = item.Id }, item); //201
        }

        // PUT api/divida/5
        [HttpPut("{id}")]
        public ActionResult Put([FromRoute] int id, [FromBody] Divida divida)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400
            }
            _service.Edit(divida);
            return Ok();
        }

        // DELETE api/divida/5
        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            var existingItem = _service.GetById(id);
            if (existingItem == null)
            {
                return NotFound(); //404
            }
            _service.Remove(id);
            return NoContent(); //204
        }
    }
}
