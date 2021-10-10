using introAPI.Models;
using introAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        IRestaurantService restaurantService;
        public RestaurantsController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }
        [HttpGet]
        public IActionResult GetRestaurants()
        {
          
            var restaurants = restaurantService.GetRestaurants();
            return Ok(restaurants);
        }
        [HttpGet("{id}")]
        public IActionResult GetRestaurant(int id)
        {
            var restaurants = restaurantService.GetRestaurants();
            var restaurant = restaurants.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                return Ok(restaurant);

            }

            return BadRequest(new { Message = $"{id} id'li bir restoran bulunamadı!" });
        }

        [HttpGet("Search/{cityId}")]
        public IActionResult GetRestaurantByCity(int cityId)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult AddRestaurant([FromBody] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                var restaurants = restaurantService.GetRestaurants();
                restaurants.Add(restaurant);
                restaurant.Id = restaurants[restaurants.Count - 1].Id + 1;
                return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.Id }, null);
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRestaurant([FromQuery]int id, [FromBody] Restaurant newRestaurant)
        {
            if (id > 0 && isExist(id))
            {
                if (ModelState.IsValid)
                {
                    //güncellendi.....
                    return Ok(newRestaurant);
                }
                return BadRequest(ModelState);
            }
            return NotFound();
        }

        private bool isExist(int id)
        {
          return  id % 2 == 0 ? true : false;
        }

        [HttpDelete()]
        public IActionResult DeleteRestaurant(List<int> id)
        {
            //silindi....
            return Ok();
        }
        [HttpGet("Rest")]
        public Restaurant GetRestaurant()
        {
            return new Restaurant { Id = 1, Name = "Test" };
        }
    }
}
