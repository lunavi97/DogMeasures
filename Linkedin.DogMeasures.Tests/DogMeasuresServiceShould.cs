using Linkedin.DogMeasures.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedin.DogMeasures.Tests
{
    [TestClass]
    public class DogMeasuresServiceShould
    {
        private static DogMeasuresService _dogMeasuresService;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _dogMeasuresService = new DogMeasuresService();
        }
    }
}
