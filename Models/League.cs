using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Models
{
    public class League
    {
        public int Id { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Club> Clubs { get; set; }
        public byte[] Img { set; get; }
        [Required]
        [NotMapped]
        public IFormFile Image { get; set; }
    }
}
