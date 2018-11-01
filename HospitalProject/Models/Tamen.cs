using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Tamen
    {
        public int Id { get; set; }
        [Display(Name = "تأمين")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "الخصم")]
        [Required]
        public decimal  Price { get; set; }
        public virtual ICollection<PatientHagz> patientHagz { get; set; }
      
    }
}