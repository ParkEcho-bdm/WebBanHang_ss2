using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBanHang.Helpers;

namespace WebBanHang.Models
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OrderController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //lấy cart từ Session
            Cart cart = HttpContext.Session.GetJson<Cart>("CART");
            if (cart == null)
            {
                cart = new Cart();
            }
            //gửi cart qua View thông qua ViewBag
            ViewBag.CART = cart;
            return View();
        }

        public IActionResult ProcessOrder(Order order)
        {
            Cart cart = HttpContext.Session.GetJson<Cart>("CART");
            if (ModelState.IsValid)
            {
                // luu trữ đơn dặt vào csdl
                order.OrderDate = DateTime.Now;
                order.Total = cart.Total;
                order.State = "Pending";
                _db.Orders.Add(order);
                _db.SaveChanges();


                // thêm chi tiết vào csdl
                foreach (var item in cart.Items)
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderId = order.Id,
                        ProductId = item.Product.Id,
                        Quantity = item.Quantity
                    };
                    // thêm vào csdl
                    _db.orderDetails.Add(orderDetail);
                    _db.SaveChanges();
                }    
                //b2. xoa gio hang
                HttpContext.Session.Remove("CART");
                //b3.tra ve view hien thi ket qua
                return View("Result");
            }
            //b1. Luu tru don hang
            ViewBag.CART = cart;

            return View("Index", order);
        }
    }
}
