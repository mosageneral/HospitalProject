﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Marad
    {
        public int Id { get; set; }
        [Display(Name = "الكشف")]
       [Required]
        public string Name { get; set; }
        [Display(Name = "السعر")]
        [Required]
        public decimal Price { get; set; }
        public ICollection<PatientHagz> patientHagz { get; set; }
    }
}