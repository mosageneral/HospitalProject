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
        [Display(Name = "إسم شركة التأمين")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "عنوان شركة التأمين")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "رقم الهاتف")]
        [Phone]
        [Required]
        public string PhoneNumber { get; set; }
        [Display(Name = "إسم مندوب شركة التأمين")]
        [Required]
        public string Agent { get; set; }
        [Display(Name = "أيميل شركة التأمين")]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Display(Name = "الموقع الإلكترني ")]
        [Url]
        [Required]
        public string WebSite { get; set; }

        [Display(Name = "الخصم")]
        [Required]
        public int  Price { get; set; }
        public virtual ICollection<PatientHagz>patientHagz{ get; set; }
      
    }
}