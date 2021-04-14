using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class ApplicationDbContet : DbContext
    {
        public  ApplicationDbContet(DbContextOptions<ApplicationDbContet>options):base(options)
            {

            }
        public DbSet<Student> Student { get; set; }
    }
}
