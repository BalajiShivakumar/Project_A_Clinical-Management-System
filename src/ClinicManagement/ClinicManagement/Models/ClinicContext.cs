using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ClinicManagement.Models
{
    public class ClinicContext : DbContext 
    {
        public ClinicContext()
        {
        }

        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        { }
        public DbSet<Appointment> AppointmentTable { get; set; }
        public DbSet<DoctorDetails> DoctorTable { get; set; }
        public DbSet<PatientDetails> PatientsTable { get; set; }
        public DbSet<SignIn> SignInTable { get; set; }
        
        public DbSet<SignUp>SignUpTable { get; set; }
       
    }

}
