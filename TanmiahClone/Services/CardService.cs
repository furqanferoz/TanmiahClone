using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TanmiahClone.Models;


namespace TanmiahClone.Services
{
    public class CardService
    {
       
       

        public CardModel GetCardData()
        {
            CardModel cardModel = new CardModel();
            cardModel.Title = "Our nuggets are made of XYZ with lorem";
            cardModel.Discription = "This is a short description about the produLorem ipsum dolor sit amet," +
                " consectetur adipiscing elit.Vivamus ullamcorper purus purus, a semper tortor ullamcorper sed." +
                " Proin dictum, risus vitae rutrum ultrices, sem massa malesuadanisl,.";
            cardModel.Image = "~/Content/Common/images/video/02.jpg"; 

            return cardModel;
            
        }

    }
}