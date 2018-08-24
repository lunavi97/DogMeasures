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

        [Test]
        public void DogIsBelowWeightIfBreedIsLabradorAndWeightInRange5And19(
            [Range(5, 19)] int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(
                "Labrador Retriever", weight);
            Assert.True(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.BelowWeight);
            Assert.AreEqual(20 - weight, result.WeightDeviation);
        }

        [Test]
        public void DogIsInIdealWeightIfBreedIsLabradorAndWeightInRange20And35(
            [Range(20, 35)] int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(
                "Labrador Retriever", weight);
            Assert.True(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.InRange);
            Assert.AreEqual(0, result.WeightDeviation);
        }

        [Test]
        public void DogIsInOverWeightIfBreedIsLabradorAndWeightInRange36And40(
            [Range(36, 40)] int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(
                "Labrador Retriever", weight);
            Assert.True(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.Overweight);
            Assert.AreEqual(weight - 35, result.WeightDeviation);
        }
    }
}
