using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProvoRestaurants.Models
{
    public class AddRestaurant
    {
        public string Name { get; set; }
        public string RestaurantName { get; set; }
        public string FavoriteDish { get; set; }
        //[RegularExpression("^[0-9]{3}[- /]?[0-9]{3}[- /]?[0-9]{4}?$)")]
        public string Phone { get; set; }
    }
}
