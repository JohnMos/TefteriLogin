using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TefteriLoginTest.Controllers
{
    public class GroupController : Controller
    {

        // GET: Group
        public ActionResult CreateGroup()
        {
            return View("CreateGroup");
        }
    }
}