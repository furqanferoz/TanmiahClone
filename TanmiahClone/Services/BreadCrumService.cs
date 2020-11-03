using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahClone.Models;

namespace TanmiahClone.Services
{
    public class BreadCrumService
    {
        public BreadCrumModel BreadCrumGetData()
        {
            BreadCrumModel breadCrumModel = new BreadCrumModel();


            breadCrumModel.MainLink = "Home";
            breadCrumModel.SubLink = "Products";
            breadCrumModel.UnderSubLink = "Chicken Nuggets";

            return breadCrumModel;
        }
    }
}