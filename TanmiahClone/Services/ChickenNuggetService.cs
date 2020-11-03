using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahClone.Models;

namespace TanmiahClone.Services
{
    public class ChickenNuggetService
    {
        ChickenNuggetModel chickenNuggetModel = new ChickenNuggetModel();
        
        public ChickenNuggetModel GetChickenNugget()
        {
            chickenNuggetModel.Name = "Chicken Nuggets";
            chickenNuggetModel.Title = "PROCESSED FOOD";
            chickenNuggetModel.Description = "Supreme Foods Processing Co.";
            chickenNuggetModel.Image = "~/Content/Common/images/spotlight/burger-icon.svg";
            return chickenNuggetModel;
        }

    }
}