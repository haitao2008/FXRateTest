using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXRate.Infrastructure
{
    public class FXRateItem
    {
        public int FXRateItemId { get; set; }
        public string FXBase { get; set; }

        public string FXSymbol { get; set; }

        public decimal FXRateValue { get; set; }
    }
}
