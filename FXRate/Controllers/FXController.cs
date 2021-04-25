using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FXRate.Domain;
using FXRate.Domain.Model;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace FXRate.Controllers
{
    [ApiController]
    [Route("FX")]
    public class FXController : ControllerBase
    {

        private readonly IFXManager _FXManager;
        private readonly IConfiguration _config;

        public FXController(IFXManager fxManager, IConfiguration config)
        {
            _FXManager = fxManager;
            _config = config;
        }

        [Route("GetFXRate")]
        [HttpGet]
        public IEnumerable<FXRateModel> GetFXRate()
        {
            var markUp =  _config.GetValue<decimal>("Markup");
            return _FXManager.GetFxRate(markUp);
        }
    }
}
