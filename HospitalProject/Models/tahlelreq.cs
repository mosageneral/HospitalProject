using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class tahlelreq
    {
        public int Id { get; set; }
       
        public int TahlelId { get; set; }
        public virtual Tahlel  tahlel { get; set; }
        [Display(Name = "اسم المريض")]
        public string PateintName { get; set; }
        [Display(Name = "تاريخ التحليل")]
        public DateTime DateOfTahlel { get; set; }
        [Display(Name = "السعر")]
        public int Price { get; set; }

    }
}