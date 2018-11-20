using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class HesabatIn
    {
        public int Id { get; set; }
        [Display(Name ="اسم المريض")]
        public string PatientName { get; set; }
        [Display(Name = "النقدية")]
        public int EntryMoney { get; set; }
        [Display(Name = "تاريخ الدفع")]
        public DateTime DateOfpay { get; set; }
        [Display(Name = "نوع التوريد")]
        public string PayType { get; set; }


    }
}