using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ERP_system.Data;
using ERP_system.Models;

namespace ERP_system.Services
{
    public class PurchaseOrderService
    {
        private readonly ApplicationDbContext _context;

        public PurchaseOrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<PurchaseOrder> GetAll() => _context.PurchaseOrders.ToList();

        public PurchaseOrder GetById(string no) => _context.PurchaseOrders.FirstOrDefault(po => po.No == no);

        public void Add(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrders.Add(purchaseOrder);
            _context.SaveChanges();
        }

        public void Update(PurchaseOrder purchaseOrder)
        {
            var existingPurchaseOrder = GetById(purchaseOrder.No);
            if (existingPurchaseOrder != null)
            {
                _context.Entry(existingPurchaseOrder).CurrentValues.SetValues(purchaseOrder);
                _context.SaveChanges();
            }
        }

        public void Delete(string no)
        {
            var purchaseOrder = GetById(no);
            if (purchaseOrder != null)
            {
                _context.PurchaseOrders.Remove(purchaseOrder);
                _context.SaveChanges();
            }
        }
    }
}
