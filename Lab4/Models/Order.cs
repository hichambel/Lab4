using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab4.Models
{
    public class Order
    {
        public SubType Sub { get; set; }
        public SubSize Size { get; set; }
        public MealDeal mealDeal { get; set; }

    }

    public enum SubType
    {
        TheHicham,
        TheKarim,
        TheAmin,
        TheHoria,
        TheMathis
    }

    public enum SubSize
    {
        ExtraSmall,
        Small,
        Medium,
        Large,
        ExtraLarge
    }

    public enum MealDeal
    {
        None,
        DrinksAndChips,
        DrinksAndCookies
    }

}