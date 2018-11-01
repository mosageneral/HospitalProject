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
        [Display(Name = "الدواء")]
        public string Content1 { get; set; }
        [Display(Name = "الدواء")]
        public string Content2 { get; set; }
        [Display(Name = "الدواء")]
        public string Content3 { get; set; }
        [Display(Name = "الدواء")]
        public string Content4 { get; set; }
        [Display(Name = "الدواء")]
        public string Content5 { get; set; }
        [Display(Name = "الدواء")]
        public string Content6 { get; set; }
        [Display(Name = "الدواء")]
        public string Content7 { get; set; }
        public virtual ICollection<PatientHagz> patientHagz { get; set; }


    }
}