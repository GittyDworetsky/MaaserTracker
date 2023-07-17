using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ReactMaaserTracker.Data
{
    public class IncomeSource
    {
        public int Id { get; set; }
        public string Source { get; set; }

        [JsonIgnore]
        public List<Income> Incomes { get; set; }

    }
}
