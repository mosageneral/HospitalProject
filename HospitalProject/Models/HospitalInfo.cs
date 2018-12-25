using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class HospitalInfo
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="إسم الدكتور")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "عنوان العيادة ")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "تفاصيل الإتصال بالهاتف")]
        public string ContactPhone { get; set; }
        [Required]
        [Display(Name = "تفاصيل الإتصال بالمحمول")]
        public string ContactMobile { get; set; }
        [Required]
        [Display(Name = "تفاصيل الإتصال بالمحمول")]
        public string Contactmobile2 { get; set; }
        [Required]
        [Display(Name = "تخصص الدكتور او الدرجة العلمية ")]
        public string DoctorName { get; set; }

    }
}