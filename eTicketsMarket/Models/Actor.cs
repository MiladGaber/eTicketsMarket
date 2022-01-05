using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicketsMarket.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Bio { get; set; }
        public string ProfileUrl { get; set; }


        //Relationships

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
