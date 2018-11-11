using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Rayreq
    {
        public int Id { get; set; }
       
        public int RayId { get; set; }
        public virtual Ray ray { get; set; }
        [Display(Name = "اسم المريض")]
        public string  PateintName { get; set; }
        [Display(Name = "التاريخ")]
        public DateTime DateOfRay { get; set; }
        [Display(Name = "السعر")]
        public int Price { get; set; }

    }
}