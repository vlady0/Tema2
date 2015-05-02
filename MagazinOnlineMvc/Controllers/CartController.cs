using MagazinOnlineMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagazinOnlineMvc.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/

        Cart c = new Cart();

        public ActionResult Index()
        {
            return View();
        }
       
    }
}
