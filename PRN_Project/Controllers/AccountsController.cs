using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRN_Project.Models;

namespace PRN_Project.Controllers
{
    [Route("account")]
    public class AccountsController : Controller
    {
        private readonly SWP_DB_FinalContext _context;

        public AccountsController(SWP_DB_FinalContext context)
        {
            _context = context;
        }

        // GET: Accounts
        
        public ActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            var account = await _context.Accounts
                .FirstOrDefaultAsync(a => a.Username == username && a.Password == password);
            if (username != null && password != null && account != null)
            {
                if (username == "admin" && password == "admin")
                {
                    HttpContext.Session.SetInt32("id", account.Id);
                    HttpContext.Session.SetString("username", username);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    HttpContext.Session.SetInt32("id", account.Id);
                    HttpContext.Session.SetString("username", username);
                    return RedirectToAction("Index", "Home");
                }    
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }
        }


        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            if (HttpContext.Session.GetString("username") == "admin"){
                HttpContext.Session.Remove("username");
                return RedirectToAction("Index", "Home");
            } else
            {
                HttpContext.Session.Remove("username");
                return RedirectToAction("Index", "Home");
            }
            
        }
        // GET: Accounts/Details/5


        // GET: Accounts/Create
        [HttpGet("[action]")]
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password,IsCus,Email,Address,Phone,CustomerType,BonusPoint")] Account account)
        {

            try
            {
                if (ModelState.IsValid)
            {
                var account1 = await _context.Accounts
            .FirstOrDefaultAsync(a => a.Username == account.Username && a.Password == account.Password);
                if (account1 != null)
                {
                    ViewBag.Message1 = "Sign Up fail! Username Exist";
                    return View("SignUp");
                }
                else
                {
                    _context.Add(account);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));
            }
      
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(account);
            }
            return View(account);
        }

        [HttpGet("[action]")]
        public ActionResult Contact()
        {
            return View();
        }
    }
}







