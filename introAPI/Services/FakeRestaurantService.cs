using introAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Services
{
    public class FakeRestaurantService : IRestaurantService
    {
        private List<Restaurant> restaurants = new List<Restaurant>
        {
               new Restaurant{ Id=1, Name="Köfteci Yusuf - Fake" },
                new Restaurant{ Id=2, Name="Mc Donalds - Fake" },
                new Restaurant{ Id=3, Name="Burger King - Fake" },
        };

        public IList<Restaurant> GetRestaurants()
        {
            return restaurants;
        }
    }
}
