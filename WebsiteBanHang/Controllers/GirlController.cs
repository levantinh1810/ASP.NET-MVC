using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteBanHang.Controllers
{
    public class GirlController : Controller
    {
        // GET: Girl
        public ActionResult Listing()
        {
            return View();
        }
    }
}