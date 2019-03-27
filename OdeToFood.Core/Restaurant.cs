using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Core
{
    public class Restaurant //: IValidatableObject
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public string Location { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
