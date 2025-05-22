using System.Data;
using System;

namespace Hospital_Test.Models
{
    public class Finance
    {
        public string finance_id { get; set; }
        public int finance_purchase { get; set; }
        public int finance_maintain { get; set; }
        public int finance_repair { get; set; }
        public int finance_type { get; set; }

    }
}
