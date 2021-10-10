using introAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Services
{
    public class RestaurantService : IRestaurantService
    {
        public IList<Restaurant> GetRestaurants()
        {
            return new List<Restaurant>
             {
               new Restaurant{ Id=1, Name="Köfteci Yusuf - Db" },
               new Restaurant{ Id=2, Name="Mc Donalds - Db" },
               new Restaurant{ Id=3, Name="Burger King - Db" },
             };
        }
    }
}
