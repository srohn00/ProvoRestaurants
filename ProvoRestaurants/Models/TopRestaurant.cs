using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProvoRestaurants.Models
{
    public class TopRestaurant
    {
        public TopRestaurant(int ranking)
        {
            Rank = ranking;
        }
        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }
#nullable enable
        public string? FavoriteDish { get; set; } = "It's all tasty!";
#nullable disable
        [Required]
        public string Address { get; set; }
#nullable enable
        //[RegularExpression("^[0-9]{3}([- /]?[0-9]{3})([- /]?[0-9]{4})?$)")]
        public string? Phone { get; set; }
        public string? Website { get; set; } = "Coming soon.";

        public static TopRestaurant[] GetRestaurants()
        {
            TopRestaurant r1 = new TopRestaurant(1)
            {
                Name = "Waffle Love",
                FavoriteDish = "Red Wonder",
                Address = "addy",
                Phone = "123-456-7890",
                Website = "linkitup"
            };
            TopRestaurant r2 = new TopRestaurant(2)
            {
                Name = "Penguin Brothers",
                FavoriteDish = "Fruity Pebbles Little Bro",
                Address = "addy",
                Phone = "123-456-7890",
                Website = "linkitup"
            };
            TopRestaurant r3 = new TopRestaurant(3)
            {
                Name = "Provo Bakery",
                FavoriteDish = "Raspberry Coconut Donut",
                Address = "addy",
                Phone = "123-456-7890",
                Website = "linkitup"
            };
            TopRestaurant r4 = new TopRestaurant(4)
            {
                Name = "Blaze Pizza",
                FavoriteDish = "Simple Pie",
                Address = "addy",
                Phone = "123-456-7890",
                Website = "linkitup"
            };
            TopRestaurant r5 = new TopRestaurant(5)
            {
                Name = "Rockwell",
                FavoriteDish = null,
                Address = "addy",
                Phone = "123-456-7890",
                Website = "linkitup"
            };
            return new TopRestaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
