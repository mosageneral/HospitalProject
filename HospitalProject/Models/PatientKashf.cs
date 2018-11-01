using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class PatientKashf
    {
        public int Id { get; set; }
        public string Tashkhees { get; set; }
        public int  patientHagzId  { get; set; }
        public virtual ICollection< PatientHagz> patientHagz { get; set; }

    }
}