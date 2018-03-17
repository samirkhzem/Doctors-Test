using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class Doctor
    {
        [Key()]
        public int Id { get; set; }
        [Required]
        [StringLength(5000)]
        public string Name { get; set; }
    }
}