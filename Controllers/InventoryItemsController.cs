using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERP_system.Models;
using ERP_system.Services;

namespace ERP_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryItemsController : ControllerBase
    {
        private readonly InventoryService _inventoryService;

        public InventoryItemsController(InventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        // GET: api/InventoryItems
        [HttpGet]
        public ActionResult<IEnumerable<InventoryItem>> GetInventoryItems()
        {
            return Ok(_inventoryService.GetAll());
        }

        // GET: api/InventoryItems/5
        [HttpGet("{id}")]
        public ActionResult<InventoryItem> GetInventoryItem(string id)
        {
            var inventoryItem = _inventoryService.GetById(id);

            if (inventoryItem == null)
            {
                return NotFound();
            }

            return inventoryItem;
        }

        // POST: api/InventoryItems
        [HttpPost]
        public ActionResult<InventoryItem> PostInventoryItem(InventoryItem inventoryItem)
        {
            _inventoryService.Add(inventoryItem);
            return CreatedAtAction(nameof(GetInventoryItem), new { id = inventoryItem.No }, inventoryItem);
        }

        // PUT: api/InventoryItems/5
        [HttpPut("{id}")]
        public IActionResult PutInventoryItem(string id, InventoryItem inventoryItem)
        {
            if (id != inventoryItem.No)
            {
                return BadRequest();
            }

            _inventoryService.Update(inventoryItem);

            return NoContent();
        }

        // DELETE: api/InventoryItems/5
        [HttpDelete("{id}")]
        public IActionResult DeleteInventoryItem(string id)
        {
            _inventoryService.Delete(id);

            return NoContent();
        }
    }
}
