using introAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Services
{
   public interface IRestaurantService
    {
        IList<Restaurant> GetRestaurants();
    }
}
