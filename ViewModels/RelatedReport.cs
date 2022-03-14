using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GpProject.ViewModels
{
    public class RelatedReport
    {
        public int LostId { get; set; }
        public int FoundId { get; set; } 
        public string LostUserId { get; set; }
        public string FoundUserId { get; set; }
    }
}
