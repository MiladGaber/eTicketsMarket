using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTicketsMarket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Bio { get; set; }
        public string ProfileUrl { get; set; }

        //Relations

        public List<Movie> Movies{ get; set; }

    }
}
