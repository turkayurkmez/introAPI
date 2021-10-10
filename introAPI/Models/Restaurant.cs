using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace introAPI.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Restaurant adı belirtilmeli!")]
        public string Name { get; set; }
        public double? Score { get; set; }
        public string Address { get; set; }
        public int? DeliveryTime { get; set; }
        public int? CityId { get; set; }


    }
}
