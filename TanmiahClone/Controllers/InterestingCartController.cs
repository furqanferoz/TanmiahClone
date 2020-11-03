using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahClone.Services;

namespace TanmiahClone.Controllers
{
    public class InterestingCartController : Controller
    {
        // GET: InterestingCart
        public ActionResult InterestAction()
        {
            InterestingCartService interestingCartService = new InterestingCartService();
            var Result = interestingCartService.GetInterestingCart();


            return PartialView("_InterestinCartItem", Result);
        }
    }
}