using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactMaaserTracker.Data;
using ReactMaaserTrackerMUI_Starter.Web.ViewModels;
using System.Diagnostics;

namespace ReactMaaserTrackerMUI_Starter.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaaserController : ControllerBase
    {
        public readonly string _connectionString;

        public MaaserController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        [HttpGet]
        [Route("getallsources")]
        public List<IncomeSource> GetAllSource()
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            return repo.GetAllSources();

        }

        [HttpPost]
        [Route("updatesource")]
        public void UpdateSource(IncomeSource source)
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            repo.UpdateSource(source);
        }

        [HttpPost]
        [Route("addsource")]
        public void AddSource(IncomeSource source)
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            repo.AddSource(source);
        }

        [HttpPost]
        [Route("deletesource")]
        public void DeleteSource(DeleteViewModel vm)
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            repo.DeleteSource(vm.Id);
        }

        [HttpPost]
        [Route("addincome")]
        public void AddIncome(Income income)
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            repo.AddIncome(income);
        }

        [HttpPost]
        [Route("addmaaserdeposit")]
        public void AddMaaserDeposit(MaaserDeposit deposit)
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            repo.AddMaaserDeposit(deposit);


        }

        [HttpGet]
        [Route("getallincomes")]
        public List<Income> GetAllIncomes()
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            return repo.GetAllIncomes();

        }

        [HttpGet]
        [Route("getallmaaserdeposits")]
        public List<MaaserDeposit> GetAllMaaserDeposits()
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            return repo.GetAllMaaserDeposits();

        }

        [HttpGet]
        [Route("gettotalincomeamount")]
        public decimal GetTotalIncomeAmount()
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            return repo.GetTotalIncomeAmount();

        }

        [HttpGet]
        [Route("gettotalmaaseramount")]
        public decimal GetTotalMaaserAmount()
        {
            var repo = new MaaserTrackerRepo(_connectionString);
            return repo.GetTotalMaaserAmount();

        }


    }
}
