using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahClone.Services;

namespace TanmiahClone.Controllers
{
    public class InterestingThingsController : Controller
    {
        // GET: InterestingThings
        public ActionResult InterstingAction()
        {
            InterestingThingsService interestingThingsService = new InterestingThingsService();
            var RelatedItems = interestingThingsService.GetInterestingThings();

            return PartialView("_RelatedItems", RelatedItems);
        }
    }
}