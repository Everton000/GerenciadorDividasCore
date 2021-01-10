using System;
using System.Collections.Generic;
using GerenciadorDividasCore.Models;
using GerenciadorDividasCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDividasCore.Controllers
{
    [Route("api/[controller]")]
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
        public ActionResult<IEnumerable<Divida>> Get()
        {
            var items = _service.GetAllItems();
            return Ok(items); //200
        }

        // GET api/divida/5
        [HttpGet("{id}")]
        public ActionResult<Divida> Get(Guid id)
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
        public ActionResult Post([FromBody] Divida value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400
            }
            var item = _service.Add(value);
            return CreatedAtAction("Get", new { id = item.Id }, item); //201
        }

        // PUT api/divida/5
        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Divida value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); //400
            }
            _service.Edit(value);
            return Ok();
        }

        // DELETE api/divida/5
        [HttpDelete("{id}")]
        public ActionResult Remove(Guid id)
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
