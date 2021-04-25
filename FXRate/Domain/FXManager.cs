using FXRate.CrossCutting;
using FXRate.Domain.Model;
using FXRate.Infrastructure;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace FXRate.Domain
{
    public class FXManager : IFXManager
    {
        public IEnumerable<FXRateModel> GetFxRate(decimal markUp)
        {
            var returnObj = new List<FXRateModel>();
            var url = "http://data.fixer.io/api/latest?access_key=da7fd704140ca9bc608786ff4bc9ccc2&base=EUR&symbols=USD,CAD,PLN,MXN";

            var strResult = Utility.HTTPGet(url);
            var JsonResult = JObject.Parse(strResult);

            if (Boolean.Parse(JsonResult["success"].ToString()))
            {
                foreach (JProperty rateProperty in JsonResult["rates"].ToList())
                {
                    var fxModel = new FXRateModel()
                    {
                        Base = JsonResult["base"].ToString(),
                        Symbol = rateProperty.Name,
                        Rate = decimal.Parse(rateProperty.Value.ToString()) * (1 + markUp)
                    };
                    returnObj.Add(fxModel);
                }
            }

            return returnObj;
        }


        public void SetFxRate(IEnumerable<FXRateModel> fxRates)
        {
            using(var fxContext = new FXContext())
            {
                foreach (var fxRateModel in fxRates)
                {

                    var existingFx = fxContext.FXRateItems.FirstOrDefault(x => x.FXBase == fxRateModel.Base && x.FXSymbol == fxRateModel.Symbol);
                    if (existingFx == null)
                    {
                        var fxRateEntity = new FXRateItem()
                        {
                            FXBase = fxRateModel.Base,
                            FXSymbol = fxRateModel.Symbol,
                            FXRateValue = fxRateModel.Rate
                        };
                        fxContext.FXRateItems.Add(fxRateEntity);
                    }
                    else
                    {
                        existingFx.FXRateValue = fxRateModel.Rate;
                    }
                }
                
                fxContext.SaveChanges();

            }
        }


        public  void GetAndSetFxRate()
        {
            var rates = GetFxRate(0);
            SetFxRate(rates);
        }

    }
}
