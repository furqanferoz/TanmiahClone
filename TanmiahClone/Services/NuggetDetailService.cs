using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahClone.Models;

namespace TanmiahClone.Services
{
    public class NuggetDetailService
    {
        NuggetDetailModel nuggetDetailModel = new NuggetDetailModel();

        public NuggetDetailModel GetNuggetDetail()
        {

            nuggetDetailModel.Title = "What’s in a Nugget?";
            nuggetDetailModel.Description = "Maltodextrin, potato starch, salt, sugar, flavourings, yeast extract,vegetables (onion powder, tomato puree powder), caramel syrup, palm fat, thickener (guar gum), sunflower oil, sage.";
            nuggetDetailModel.DescriptionOne = "No Allergens to Declare - this product does not contain allergenic ingredients which require declaration under EU regulation 1169/2011 (Annex II).";
            nuggetDetailModel.NutritionPP = "Nutrition per pack (500g)";
            nuggetDetailModel.Order = "Want to order in bulk?";
            nuggetDetailModel.Energy = "Energy";
            nuggetDetailModel.Carbohydrate = "Carbohydrates";
            nuggetDetailModel.Fat = "Fat";
            nuggetDetailModel.Protine = "Proteins";
            



            return nuggetDetailModel;
        }

    }
}