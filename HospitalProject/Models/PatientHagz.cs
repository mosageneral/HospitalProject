using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class PatientHagz
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "اسم المريض")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "عمر المريض")]
        public int Age { get; set; }
        [Required]
        [Display(Name = "عنوان المريض")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "تاريخ الحجز")]
        public DateTime? KashfDate { get; set; }

        [Required]
        [Phone]
        [Display(Name = "رقم الهاتف")]
        public string Number { get; set; }
        public int MaradId { get; set; }
        public virtual Marad marad { get; set; }
        public int TamenId { get; set; }
        public virtual Tamen tamen { get; set; }
        [Display (Name ="تم الدفع")]
        public bool IsBaid { get; set; }
        [Display(Name = "التشخيص")]
        public string Tashkhees { get; set; }
        [Display(Name = "الروشته")]
        public string Rosheta { get; set; }
        public int AdwyaId { get; set; }
        public virtual Adwya adwya { get; set; }
        public int RayId { get; set; }
        public virtual Ray ray { get; set; }

    }
}