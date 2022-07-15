using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VirtualDesk.Models;
using workoutapp.Models;

namespace workoutapp.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class DataContext :DbContext
    {
        /// <summary>
        ///     <para>
        ///         Initializes a new instance of the <see cref="DbContext" /> class using the specified options.
        ///         The <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" /> method will still be called to allow further
        ///         configuration of the options.
        ///     </para>
        /// </summary>
        /// <param name="options">The options for this context.</param>
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Exercise> exercises { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<BMICalculator> BMIResults { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<BodyMeasure> BodyMeasure { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<BodyFatCalculator> BodyFatCalculator { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<EmailAccountList> emailAccountLists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<AccountsList> accountsLists { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Workout> workout { get; set; }
    }
}
