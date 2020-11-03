using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahClone.Services;

namespace TanmiahClone.Controllers
{
    public class ChickenNuggetController : Controller
    {
        // GET: ChickenNugget
        public ActionResult ChickenNuggetAction()
        {
            ChickenNuggetService chickenNuggetService = new ChickenNuggetService();
            var chickenData = chickenNuggetService.GetChickenNugget();

            return PartialView("_ChickenNuggetView", chickenData);
        }
    }
}