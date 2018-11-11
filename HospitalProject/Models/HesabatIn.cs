using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalProject.Models
{
    public class HesabatIn
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public int EntryMoney { get; set; }
        public DateTime DateOfpay { get; set; }
        public string PayType { get; set; }


    }
}