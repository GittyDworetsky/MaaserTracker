using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactMaaserTracker.Data
{
    public class MaaserTrackerRepo
    {
        public string _connectionString;

        public MaaserTrackerRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<IncomeSource> GetAllSources()
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            return context.IncomeSources.ToList();
        }

        public void UpdateSource(IncomeSource source)
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            context.Database.ExecuteSqlInterpolated($"UPDATE IncomeSources SET source={source.Source} WHERE id={source.Id}");
            context.SaveChanges();
        }

        public void AddSource(IncomeSource source)
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            context.IncomeSources.Add(source);
            context.SaveChanges();

        }

        public void DeleteSource(int id)
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            context.Database.ExecuteSqlInterpolated($"DELETE FROM IncomeSources WHERE Id = {id}");
        }

        public void AddIncome(Income income)
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            context.IncomeDeposits.Add(income);
            context.SaveChanges();
        }

        public void AddMaaserDeposit(MaaserDeposit deposit)
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            context.MaaserDeposits.Add(deposit);
            context.SaveChanges();
        }

        public List<Income> GetAllIncomes()
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            return context.IncomeDeposits.ToList();
        }

        public List<MaaserDeposit> GetAllMaaserDeposits()
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            return context.MaaserDeposits.ToList();
        }

        public decimal GetTotalIncomeAmount()
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            return context.IncomeDeposits.Select(i => i.Amount).Sum();
        }

        public decimal GetTotalMaaserAmount()
        {
            var context = new ReactMaaserTrackerDataContext(_connectionString);
            return context.MaaserDeposits.Select(i => i.Amount).Sum();
        }
    }
}
