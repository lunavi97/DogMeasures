using Linkedin.DogMeasures.Exceptions;
using Linkedin.DogMeasures.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedin.DogMeasures.NUnit
{
    [TestFixture]
    public class DogMeasuresServiceShould
    {
        private DogMeasuresService _dogMeasuresService;

        [OneTimeSetUp]
        public void Setup()
        {
            _dogMeasuresService = new DogMeasuresService();
        }

        [Test]
        public void ThrowsArgumentNullExceptionIfBreedIsNull()
        {
            Assert.Throws<ArgumentNullException>(
                () => _dogMeasuresService.CheckDogIdealWeight(null, 0));
        }

        [Test]
        public void ThrowsBreedNotFoundExceptionIfBreedIsSamoyedo()
        {
            Assert.Throws<BreedNotFoundException>(
                () => _dogMeasuresService.CheckDogIdealWeight("Samoyedo", 20));
        }

        [Test]
        public void ThrowsArgumentOutOfRangeExceptionIfWeightIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => _dogMeasuresService.CheckDogIdealWeight("Caniche", -3));
        }
    }
}
