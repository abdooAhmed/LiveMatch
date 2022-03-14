using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GpProject.ViewModels
{
    public class RegistrationViewModel
    {
        [Required]
        
        
        public string UserName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
       
        [Required]
        public string ConfirmPassword { get; set; }
        
        
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
