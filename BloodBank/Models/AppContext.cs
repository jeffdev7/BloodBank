using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBank.Models
{
    public class AppContext: DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public AppContext(DbContextOptions<AppContext> options): base(options)
        {

        }
    }
}
