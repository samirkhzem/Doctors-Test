using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Doctors.Models
{
    public class PatientContext : DbContext
    {
        public PatientContext()
            :base("Doctors")
        {
            
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<InsuranceTypes> EfResources { get; set; }
        public DbSet<Ecg> Ecgs { get; set; }
        public DbSet<LabResult> LabResults { get; set; }
        public DbSet<ImagingResult> ImagingResults { get; set; }
    }
}