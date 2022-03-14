using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Models
{
    public class ServerLink
    {
        public int Id { get; set; }
        [Required]
        public string Link { get; set; }
        public int ServerNameId { get; set; }
        public ServerName ServerName { get; set; } 
    }
}
