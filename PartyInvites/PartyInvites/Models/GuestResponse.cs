using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your damn name") ]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your fucking email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Dude! Will you come or not?!")]
        public bool? WillAttend { get; set; }
    }
}