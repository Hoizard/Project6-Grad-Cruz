using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace You.Models
{
    public class Name
    {
        [DisplayName("First Name")]
        [Required]
        public virtual string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public virtual string Lastname { get; set; }
    }
}