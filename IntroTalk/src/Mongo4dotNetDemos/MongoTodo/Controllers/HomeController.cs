using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoTodo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult AjaxVersion()
        {
            return View();
        }

        public ActionResult MvcVersion()
        {
            return View();
        }


    }
}