using Entity_Nested_Structure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Entity_Nested_Structure.Controllers
{
    public class HomeController : Controller
    {
        private readonly EntityContext db = new EntityContext();
        public ActionResult Index()
        {
            var result = db.Entities.ToList();

            return View(result);
        }
    }
}