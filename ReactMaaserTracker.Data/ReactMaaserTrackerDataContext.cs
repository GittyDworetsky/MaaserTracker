using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactMaaserTracker.Data
{
    public class ReactMaaserTrackerDataContext : DbContext
    {
        private readonly string _connectionString;

        public ReactMaaserTrackerDataContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Income> IncomeDeposits { get; set; }
        public DbSet<MaaserDeposit> MaaserDeposits { get; set; }
        public DbSet<IncomeSource> IncomeSources { get; set; }

    }
}
