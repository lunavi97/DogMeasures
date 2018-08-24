using Linkedin.DogMeasures.Exceptions;
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

        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void ThrowsArgumentNullExceptionIfBreedIsNull()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(null, 0);
        }

        [ExpectedException(typeof(BreedNotFoundException))]
        [TestMethod]
        public void ThrowsBreedNotFoundExceptionIfBreedIsSamoyedo()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Samoyedo", 20);
        }
    }
}
