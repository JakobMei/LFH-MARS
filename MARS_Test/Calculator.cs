using NUnit.Framework;
using M.A.R.S.Calculators;
using System;
using System.Collections.Generic;
using System.Text;
using M.A.R.S.ViewModel;
namespace MARS_Test
{
    public class Calculator_Tests
    {
        [SetUp]
        public void Setup()
        {
            Calculator calculator = new Calculator();
            ConfigVM configVMInput = new ConfigVM();
            ConfigVM configVMResult = new ConfigVM();
            ConfigVM configVMExpected = new ConfigVM();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}