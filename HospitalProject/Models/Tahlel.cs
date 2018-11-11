using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class Tahlel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal  Price { get; set; }
        public virtual  ICollection <PatientHagz>patientHagz { get; set; }
        public virtual ICollection<tahlelreq> tahlelreq { get; set; }

    }
}