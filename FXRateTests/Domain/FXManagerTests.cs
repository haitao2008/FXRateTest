using Microsoft.VisualStudio.TestTools.UnitTesting;
using FXRate.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FXRate.Domain.Model;

namespace FXRate.Domain.Tests
{
    [TestClass()]
    public class FXManagerTests
    {
        [TestMethod()]
        public void GetSetFxRateTest()
        {
            var fxManager = new FXManager();           
            fxManager.GetAndSetFxRate();
        }
       
    }
}