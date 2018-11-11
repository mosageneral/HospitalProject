using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Workers
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="الاسم")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "الوظيفة")]
        public string Job { get; set; }
        [Required]
        [Display(Name = "السن")]
        public string Age { get; set; }
        [Required]
        [Display(Name = "المرتب")]
        public string Salary { get; set; }
        [Required]
        [Display(Name = "العنوان")]
        public string Address { get; set; }
        [Required]
        [Phone]
        [Display(Name = "رقم الهاتف")]
        public string Phone { get; set; }
        
        [Display(Name = "وصف")]
        public string Describ { get; set; }
       

    }
}