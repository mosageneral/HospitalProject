using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Amaleyat
    {
        public int Id { get; set; }
        [Display(Name="اسم العملية" )]
        public string Name { get; set; }
        [Display(Name = "اسم المريض")]
        public string PatientName { get; set; }
        [Display(Name = "السعر")]
        public int Price { get; set; }
        [Display(Name = "التاريخ")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime  Date { get; set; }
        [Display(Name = "تمت")]
        public bool IsDone { get; set; }



    }
}