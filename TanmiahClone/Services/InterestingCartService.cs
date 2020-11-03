using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TanmiahClone.Models;

namespace TanmiahClone.Services
{
    public class InterestingCartService
    {
        InterestingCartModel interestingCartModel = new InterestingCartModel();



        public InterestingCartModel GetInterestingCart()
        {
            //interestingCartModel.Name.Add("RED MEAT");
            //interestingCartModel.Name.Add("Frozen Food");
            //interestingCartModel.Name.Add("RED MEAT");
            //interestingCartModel.Name.Add("Frozen Food");

            //interestingCartModel.Title.Add("Grilled chicken breast");
            //interestingCartModel.Title.Add("Featured Product Name");
            //interestingCartModel.Title.Add("Grilled chicken breast");
            //interestingCartModel.Title.Add("Featured Product Name");

            //interestingCartModel.Description.Add("1 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.");
            //interestingCartModel.Description.Add("2 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.");
            //interestingCartModel.Description.Add("3 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.");
            //interestingCartModel.Description.Add("4 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.");

            //interestingCartModel.Images.Add("~/Content/Common/images/listing-cards/image-5.jpg");
            //interestingCartModel.Images.Add("~/Content/Common/images/listing-cards/image-6.jpg");
            //interestingCartModel.Images.Add("~/Content/Common/images/listing-cards/image-5.jpg");
            //interestingCartModel.Images.Add("~/Content/Common/images/listing-cards/image-6.jpg");

            interestingCartModel.list.Add(new InterestingCartGetSet { Name = "RED MEAT",
                Title = "Grilled chicken breast",
                Discription = "1 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.",
                Images = "~/Content/Common/images/listing-cards/image-5.jpg"
            });
            interestingCartModel.list.Add(new InterestingCartGetSet
            {
                Name = "Frozen Food",
                Title = "Featured Product Name",
                Discription = "2 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.",
                Images = "~/Content/Common/images/listing-cards/image-6.jpg"
            }); interestingCartModel.list.Add(new InterestingCartGetSet
            {
                Name = "RED MEAT",
                Title = "Grilled chicken breast",
                Discription = "3 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.",
                Images = "~/Content/Common/images/listing-cards/image-5.jpg"
            }); interestingCartModel.list.Add(new InterestingCartGetSet
            {
                Name = "Frozen Food",
                Title = "Featured Product Name",
                Discription = "4 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.",
                Images = "~/Content/Common/images/listing-cards/image-6.jpg"
            });
            interestingCartModel.list.Add(new InterestingCartGetSet
            {
                Name = "Frozen Food",
                Title = "Featured Product Name",
                Discription = "4 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.",
                Images = "~/Content/Common/images/listing-cards/image-6.jpg"
            }); interestingCartModel.list.Add(new InterestingCartGetSet
            {
                Name = "Frozen Food",
                Title = "Featured Product Name",
                Discription = "4 This is a short description about the type of products provided by Agricultural Development Company.Lorem ipsum dolor sit amet.",
                Images = "~/Content/Common/images/listing-cards/image-6.jpg"
            });

            return interestingCartModel;
        }
    }
}