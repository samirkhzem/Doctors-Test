using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Ecg
    {
        [Required]
        [Key, Column(Order = 0)]
        public int PatientId { get; set; }
        [Required]
        [Key, Column(Order = 1)]
        public int DoctorId { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        public string SerialNb { get; set; }
        
        public byte File { get; set; }

    }
}