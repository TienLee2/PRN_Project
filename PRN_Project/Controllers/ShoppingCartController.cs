using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagedList.Core;
using PRN_Project.ModelView;
using System.Collections.Generic;
using System.Linq;
using PRN_Project.Models;
using System;
using PRN_Project.Extensions;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PRN_Project.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly SWP_DB_FinalContext _context;
        public INotyfService _notyfService { get; }
        public ShoppingCartController(SWP_DB_FinalContext context, INotyfService notyfService)
        {
            _context = context;
            _notyfService = notyfService;
        }


        public List<CartItem> GioHang
        {
            get
            {
                var gh = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (gh == default(List<CartItem>))
                {
                    gh = new List<CartItem>();
                }
                return gh;
            }
        }


        [HttpGet]
        public IActionResult AddToCart(int id, int? amount)
        {
            List<CartItem> cart = GioHang;

            //Them san pham vao gio hang
            CartItem item = cart.SingleOrDefault(p => p.product.Id == id);
            if (item != null) // da co => cap nhat so luong
            {
                amount = 1;
                item.amount = item.amount + amount.Value;
                //luu lai session

                HttpContext.Session.Set<List<CartItem>>("GioHang", cart);

            }
            else
            {
                Product hh = _context.Products.SingleOrDefault(p => p.Id == id);
                item = new CartItem
                {
                    amount = amount.HasValue ? amount.Value : 1,
                    product = hh
                };
                cart.Add(item);//Them vao gio
            }
            //Luu lai Session
            HttpContext.Session.Set<List<CartItem>>("GioHang", cart);

            _notyfService.Success("Thêm sản phẩm thành công");
            return RedirectToAction("Index", "ShoppingCart");
        }

        [HttpGet]
        public IActionResult Subtract(int id, int? amount)
        {

            List<CartItem> cart = GioHang;

            //Them san pham vao gio hang
            CartItem item = cart.SingleOrDefault(p => p.product.Id == id);

            if(item.amount != 1)
            {
                if (item != null) // da co => cap nhat so luong
                {
                    amount = 1;
                    item.amount = item.amount - amount.Value;
                    //luu lai session

                    HttpContext.Session.Set<List<CartItem>>("GioHang", cart);

                }
                else
                {
                    Product hh = _context.Products.SingleOrDefault(p => p.Id == id);
                    item = new CartItem
                    {
                        amount = amount.HasValue ? amount.Value : 1,
                        product = hh
                    };
                    cart.Add(item);//Them vao gio
                }
            }
            else
            {
                Remove(id);
            }

            return RedirectToAction("Index", "ShoppingCart");
        }


        [HttpGet]
        public ActionResult Remove(int id)
        {
            List<CartItem> cart = GioHang;
            CartItem item = cart.SingleOrDefault(p => p.product.Id == id);
            if (item != null)
            {
                cart.Remove(item);
            }
            //luu lai session
            HttpContext.Session.Set<List<CartItem>>("GioHang", cart);
            return RedirectToAction("Index", "ShoppingCart");
        }

        [Route("cart.html")]
        public IActionResult Index()
        {
            return View(GioHang);
        }
    }
}
