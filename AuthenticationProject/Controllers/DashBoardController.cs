using AuthenticationProject.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationProject.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        [AuthenticationFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}