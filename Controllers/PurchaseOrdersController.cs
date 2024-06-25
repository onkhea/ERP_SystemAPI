using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ERP_system.Models;
using ERP_system.Services;

namespace ERP_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly PurchaseOrderService _purchaseOrderService;

        public PurchaseOrdersController(PurchaseOrderService purchaseOrderService)
        {
            _purchaseOrderService = purchaseOrderService;
        }

        // GET: api/PurchaseOrders
        [HttpGet]
        public ActionResult<IEnumerable<PurchaseOrder>> GetPurchaseOrders()
        {
            return _purchaseOrderService.GetAll();
        }

        // GET: api/PurchaseOrders/{id}
        [HttpGet("{id}")]
        public ActionResult<PurchaseOrder> GetPurchaseOrder(string id)
        {
            var purchaseOrder = _purchaseOrderService.GetById(id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            return purchaseOrder;
        }

        // POST: api/PurchaseOrders
        [HttpPost]
        public ActionResult<PurchaseOrder> PostPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderService.Add(purchaseOrder);
            return CreatedAtAction(nameof(GetPurchaseOrder), new { id = purchaseOrder.No }, purchaseOrder);
        }

        // PUT: api/PurchaseOrders/{id}
        [HttpPut("{id}")]
        public IActionResult PutPurchaseOrder(string id, PurchaseOrder purchaseOrder)
        {
            if (id != purchaseOrder.No)
            {
                return BadRequest();
            }

            _purchaseOrderService.Update(purchaseOrder);
            return NoContent();
        }

        // DELETE: api/PurchaseOrders/{id}
        [HttpDelete("{id}")]
        public IActionResult DeletePurchaseOrder(string id)
        {
            var purchaseOrder = _purchaseOrderService.GetById(id);

            if (purchaseOrder == null)
            {
                return NotFound();
            }

            _purchaseOrderService.Delete(id);
            return NoContent();
        }
    }
}
