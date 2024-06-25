using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ERP_system.Data;
using ERP_system.Models;

namespace ERP_system.Services
{
    public class SalesOrderLineService
    {
        private readonly ApplicationDbContext _context;

        public SalesOrderLineService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<SalesOrderLine> GetAll() => _context.OrderLines.ToList();

        public SalesOrderLine GetById(string documentNo, int lineNo) => _context.OrderLines.FirstOrDefault(ol => ol.Document_No == documentNo && ol.Line_No == lineNo);

        public void Add(SalesOrderLine orderLine)
        {
            _context.OrderLines.Add(orderLine);
            _context.SaveChanges();
        }

        public void Update(SalesOrderLine orderLine)
        {
            var existingOrderLine = GetById(orderLine.Document_No, orderLine.Line_No);
            if (existingOrderLine != null)
            {
                _context.Entry(existingOrderLine).CurrentValues.SetValues(orderLine);
                _context.SaveChanges();
            }
        }

        public void Delete(string documentNo, int lineNo)
        {
            var orderLine = GetById(documentNo, lineNo);
            if (orderLine != null)
            {
                _context.OrderLines.Remove(orderLine);
                _context.SaveChanges();
            }
        }
    }
}
