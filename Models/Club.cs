using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Models
{
    public class Club
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int LeagueId { get; set; }
        
        public League League { get; set; }
        public byte[] Img { set; get; }
        [Required]
        [NotMapped]
        public IFormFile Image { get; set; }

    }
}
