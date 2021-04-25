using FXRate.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXRate.Domain
{
    public interface IFXManager
    {
       public IEnumerable<FXRateModel> GetFxRate( decimal markUp);
       public void SetFxRate(IEnumerable<FXRateModel> fxRates);
       public void GetAndSetFxRate();
    }
}
