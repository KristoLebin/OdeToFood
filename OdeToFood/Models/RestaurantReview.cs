using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Range(1, 10)]
        [Required]
        public int rating { get; set; }
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }
        public int RestaurantId { get; set; }
        [Display(Name = "User Name")]
        public string ReviewerName { get; set; }
    }
}