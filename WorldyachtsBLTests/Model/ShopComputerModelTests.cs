﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace WorldyachtsBl.Model.Tests
{
    [TestClass()]
    public class ShopComputerModelTests
    {
        [TestMethod()]
        public void StartTest()
        {
            var model = new ShopComputerModel();
            // model.Start();
            Thread.Sleep(10000);
        }
    }
}