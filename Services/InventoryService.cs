using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ERP_system.Data;
using ERP_system.Models;

namespace ERP_system.Services
{
    public class InventoryService
    {
        private readonly ApplicationDbContext _context;

        public InventoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<InventoryItem> GetAll() => _context.InventoryItems.ToList();

        public InventoryItem GetById(string id) => _context.InventoryItems.FirstOrDefault(ii => ii.No == id);

        public void Add(InventoryItem inventoryItem)
        {
            _context.InventoryItems.Add(inventoryItem);
            _context.SaveChanges();
        }

        public void Update(InventoryItem inventoryItem)
        {
            var existingInventoryItem = GetById(inventoryItem.No);
            if (existingInventoryItem != null)
            {
                _context.Entry(existingInventoryItem).CurrentValues.SetValues(inventoryItem);
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var inventoryItem = GetById(id);
            if (inventoryItem != null)
            {
                _context.InventoryItems.Remove(inventoryItem);
                _context.SaveChanges();
            }
        }
    }
}
