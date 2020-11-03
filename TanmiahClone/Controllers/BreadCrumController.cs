using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahClone.Services;

namespace TanmiahClone.Controllers
{
    public class BreadCrumController : Controller
    {
        // GET: BreadCrumController
        public ActionResult BreadCrumAction()
        {
            BreadCrumService breadCrumService = new BreadCrumService();
            var breadcrum = breadCrumService.BreadCrumGetData();
            return PartialView("_BreadCrum",breadcrum);
        }
    }
}