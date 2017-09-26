using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")][RegularExpression(".+\\@.+\\..+",ErrorMessage ="Please enter a Valid email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify wheather you will attend")]
        public bool? WillAttend
        {
            get; set;
        }
    }
}
