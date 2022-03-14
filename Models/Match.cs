using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnMatch.Models
{
    public class Match
    {
        public int Id { get; set; }
        [Required]

        public int club1Id { get; set; }
        public Club club1 { get; set; }
        public int result1 { get; set; }
        [Required]
        public int club2Id { get; set; }
        public Club club2 { get; set; }
        public int result2 { get; set; }
        [DisplayFormat(DataFormatString = "{HH:mm}")]
        public DateTime date { get; set; }
        public int LeagueId { get; set; }
        public League league { get; set; }
        public string stadium { get; set; }
        public int ServerNameId { get; set; }
        [ForeignKey("ServerNameId")]
        public ServerName serverName { get; set; }
        
        
    }
}
