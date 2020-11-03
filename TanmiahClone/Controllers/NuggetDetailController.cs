using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TanmiahClone.Services;

namespace TanmiahClone.Controllers
{
    public class NuggetDetailController : Controller
    {
        // GET: NuggetDetail
        public ActionResult NuggetDetail()
        {
            NuggetDetailService nuggetDetailService = new NuggetDetailService();
            var nugget_Detail = nuggetDetailService.GetNuggetDetail();
            return PartialView("_NuggetDetail",nugget_Detail);
        }
    }
}