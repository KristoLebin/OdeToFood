using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public int rating { get; set; }
        public string Body { get; set; }
        public int RestaurantId { get; set; }
    }
}