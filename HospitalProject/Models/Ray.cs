using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Ray
    {
        public int Id { get; set; }
        [Display(Name = "اسم الأشعه")]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<PatientHagz> patientHagz { get; set; }
    }
}