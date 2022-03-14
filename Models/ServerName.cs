using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Models
{
    public class ServerName
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<ServerLink> serverLinks { get; set; }
        public List<Match> Matches { get; set; }

    }
}
