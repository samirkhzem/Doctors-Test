using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Doctors.Models
{
    public class SchedulerContext : DbContext
    {
        public SchedulerContext()
            :base("Doctors")
        {
            
        }
        public DbSet<EFAppointment> EfAppointments { get; set; }
        public DbSet<EFResource> EfResources { get; set; }
    }
}