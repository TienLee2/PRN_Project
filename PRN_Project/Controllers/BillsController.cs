using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PRN_Project.Models;

namespace PRN_Project.Controllers
{
    public class BillsController : Controller
    {
        private readonly SWP_DB_FinalContext _context;

        public BillsController(SWP_DB_FinalContext context)
        {
            _context = context;
        }

        // GET: Bills
        public async Task<IActionResult> Index()
        {
            
            var SWP_DB_FinalContext = _context.Bills.Include(b => b.IdAccountNavigation);
            return View(await SWP_DB_FinalContext.ToListAsync());
        }

        // GET: Bills/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bill = await _context.Bills
                .Include(b => b.IdAccountNavigation)
                .FirstOrDefaultAsync(m => m.BillId == id);
            if (bill == null)
            {
                return NotFound();
            }

            var chitietbill = _context.Details
              .AsNoTracking()
              .Where(x => x.BillId == bill.BillId)
              .OrderBy(x => x.BillId).ToList();
            ViewBag.ChiTiet = chitietbill;

            return View(bill);
        }

    }
}
