using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Activate
    {
        public int id { get; set; }
        [Required]
        public DateTime DateNow { get; set; }
        [Required]

        public DateTime EndDate { get; set; }
        [Required]

        public bool Activated { get; set; }
    }
}