using ASP.NET_Warehouse_System.Data;
using ASP.NET_Warehouse_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Warehouse_System.Controllers
{
    class WarehouseController: Controller
    {
        private ApplicationDbContext _context;
        
        public WarehouseController(ApplicationDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            var Warehouse = await _context.Warehouses.ToListAsync();
            return View(Warehouse);
        }
    }
}