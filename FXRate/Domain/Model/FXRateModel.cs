using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXRate.Domain.Model
{
    public class FXRateModel
    {
        public string Base { get; set; }

        public string Symbol { get; set; }

        public decimal Rate { get; set; }
    }
}
