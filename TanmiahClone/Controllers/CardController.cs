using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahClone.Services;

namespace TanmiahClone.Controllers
{
    public class CardController : Controller
    {
        // GET: Card
        public ActionResult Recipe()
        {
            CardService cardService = new CardService();
            var cardServiceData = cardService.GetCardData();

            return PartialView("_Card",cardServiceData);
        }
    }
}