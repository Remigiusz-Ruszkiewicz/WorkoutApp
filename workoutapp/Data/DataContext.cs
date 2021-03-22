using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDesk.Models;
using workoutapp.Models;

namespace workoutapp.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        public DbSet<Exercise> exercises { get; set; }
        public DbSet<BMICalculator> BMIResults { get; set; }
        public DbSet<BodyMeasure> BodyMeasure { get; set; }
        public DbSet<BodyFatCalculator> BodyFatCalculator { get; set; }
        public DbSet<EmailAccountList> emailAccountLists { get; set; }
        public DbSet<AccountsList> accountsLists { get; set; }

        //public DbSet<AccountsList> accountsLists { get; set; }
    }
}
