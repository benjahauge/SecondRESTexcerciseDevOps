using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRESTexcercise.Manager;
using FirstRESTexcercise.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstRESTexcercise.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ItemsController : ControllerBase
	{
		private readonly ItemsManager _manager = new ItemsManager();
		// GET: api/<ItemsController>
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status204NoContent)]
		[HttpGet("Contains/{substring}")]
		public ActionResult<IEnumerable<Item>> GetWithContains(string substring)
		{
			List<Item> result = _manager.GetAll(substring);
			if (result.Count > 0)
			{
				return Ok(result);
			}
			else
			{
				return NoContent();

			}
		}

		// GET api/<ItemsController>/5
		[HttpGet("{id}")]
		public Item Get(int id)
		{
			return _manager.GetById(id);
		}

		// POST api/<ItemsController>
		[HttpPost]
		public Item Post([FromBody] Item value)
		{
			return _manager.Add(value);
		}

		// PUT api/<ItemsController>/5
		[HttpPut("{id}")]
		public Item Put(int id, [FromBody] Item value)
		{
			return _manager.Update(id, value);
		}

		// DELETE api/<ItemsController>/5
		[HttpDelete("{id}")]
		public Item Delete(int id)
		{
			return _manager.Delete(id);
		}
	}
}
