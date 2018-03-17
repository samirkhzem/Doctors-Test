using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Medications
    {
        [Key()]
        public int PatientId { get; set; }
        [Key()]
        public int DoctorId { get; set; }
        [Key()]
        public string SerialNb { get; set; }
        [Required]
        [StringLength(5000)]
        public string Medication { get; set; }
    }
}