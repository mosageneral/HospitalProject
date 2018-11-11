using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Adwya
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "اسم مجموعة الدواء")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "الدواء")]
        public string Content0 { get; set; }
        
       
        public virtual ICollection<PatientHagz> patientHagz { get; set; }


    }
}