using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ReactMaaserTracker.Data
{
    public class Income
    {
        public int Id { get; set; }
        public int IncomeSourceId { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateSubmitted { get; set; }

        public IncomeSource IncomeSource { get; set; }

    }
}
