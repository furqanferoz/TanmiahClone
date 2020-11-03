using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahClone.Models;

namespace TanmiahClone.Services
{
    public class InterestingThingsService
    {
        InterestingThingsModel interestingThingsModel = new InterestingThingsModel();

        public InterestingThingsModel GetInterestingThings()
        {

            interestingThingsModel.Title = " YOU MIGHT ALSO BE INTERESTED IN THESE";

            return interestingThingsModel;
        }

    }
}