using Microsoft.AspNetCore.Mvc;
using ERP_system.Models;
using ERP_system.Services;
using System.Collections.Generic;

namespace ERP_system.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderLinesController : ControllerBase
    {
        private readonly SalesOrderLineService _orderLineService;

        public OrderLinesController(SalesOrderLineService orderLineService)
        {
            _orderLineService = orderLineService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<SalesOrderLine>> Get()
        {
            return _orderLineService.GetAll();
        }

        [HttpGet("{documentNo}/{lineNo}")]
        public ActionResult<SalesOrderLine> Get(string documentNo, int lineNo)
        {
            var orderLine = _orderLineService.GetById(documentNo, lineNo);
            if (orderLine == null)
            {
                return NotFound();
            }
            return orderLine;
        }

        [HttpPost]
        public ActionResult Post([FromBody] SalesOrderLine orderLine)
        {
            _orderLineService.Add(orderLine);
            return CreatedAtAction(nameof(Get), new { documentNo = orderLine.Document_No, lineNo = orderLine.Line_No }, orderLine);
        }

        [HttpPut("{documentNo}/{lineNo}")]
        public ActionResult Put(string documentNo, int lineNo, [FromBody] SalesOrderLine orderLine)
        {
            if (documentNo != orderLine.Document_No || lineNo != orderLine.Line_No)
            {
                return BadRequest();
            }
            _orderLineService.Update(orderLine);
            return NoContent();
        }

        [HttpDelete("{documentNo}/{lineNo}")]
        public ActionResult Delete(string documentNo, int lineNo)
        {
            _orderLineService.Delete(documentNo, lineNo);
            return NoContent();
        }
    }
}
