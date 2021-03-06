﻿using Linkedin.DogMeasures.Exceptions;
using Linkedin.DogMeasures.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedin.DogMeasures.Test.MSTest
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

        [TestCategory("exception")]
        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void ThrowsArgumentNullExceptionIfBreedIsNull()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(null, 0);
        }

        [TestCategory("exception")]
        [ExpectedException(typeof(BreedNotFoundException))]
        [TestMethod]
        public void ThrowsBreedNotFoundExceptionIfBreedIsSamoyedo()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Samoyedo", 20);
        }

        [Priority(1)]
        [TestCategory("labrador")]
        [DataTestMethod]
        [DataRow("Labrador Retriever", 20)]
        [DataRow("Labrador Retriever", 21)]
        [DataRow("Labrador Retriever", 22)]
        [DataRow("Labrador Retriever", 23)]
        [DataRow("Labrador Retriever", 24)]
        [DataRow("Labrador Retriever", 25)]
        [DataRow("Labrador Retriever", 26)]
        [DataRow("Labrador Retriever", 27)]
        [DataRow("Labrador Retriever", 28)]
        [DataRow("Labrador Retriever", 29)]
        [DataRow("Labrador Retriever", 30)]
        [DataRow("Labrador Retriever", 31)]
        [DataRow("Labrador Retriever", 31)]
        [DataRow("Labrador Retriever", 32)]
        [DataRow("Labrador Retriever", 33)]
        [DataRow("Labrador Retriever", 34)]
        [DataRow("Labrador Retriever", 35)]
        public void DogIsInIdealWeightIfBreedIsLabradorAndWeightInRange20And40(
            string breed, int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(breed, weight);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.InRange);
            Assert.AreEqual(0, result.WeightDeviation);
        }

        [Priority(1)]
        [TestCategory("labrador")]
        [DataTestMethod]
        [DataRow("Labrador Retriever", 5)]
        [DataRow("Labrador Retriever", 6)]
        [DataRow("Labrador Retriever", 7)]
        [DataRow("Labrador Retriever", 8)]
        [DataRow("Labrador Retriever", 9)]
        [DataRow("Labrador Retriever", 10)]
        [DataRow("Labrador Retriever", 11)]
        [DataRow("Labrador Retriever", 12)]
        [DataRow("Labrador Retriever", 13)]
        [DataRow("Labrador Retriever", 14)]
        [DataRow("Labrador Retriever", 15)]
        [DataRow("Labrador Retriever", 16)]
        [DataRow("Labrador Retriever", 17)]
        [DataRow("Labrador Retriever", 18)]
        [DataRow("Labrador Retriever", 19)]
        public void DogIsBelowWeightIfBreedIsLabradorAndWeightIsInRange5And19(
            string breed, int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(breed, weight);
            Assert.IsTrue(
                result.DeviationType ==
                Models.DogWeightInfo.WeightDeviationType.BelowWeight);
            Assert.AreEqual(20 - weight, result.WeightDeviation);
        }

        [Priority(1)]
        [TestCategory("labrador")]
        [DataTestMethod]
        [DataRow("Labrador Retriever", 36)]
        [DataRow("Labrador Retriever", 37)]
        [DataRow("Labrador Retriever", 38)]
        [DataRow("Labrador Retriever", 39)]
        [DataRow("Labrador Retriever", 40)]
        public void DogIsInOverWeightIfBreedIsLabradorAndWeightInRange36And40(
            string breed, int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(breed, weight);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.Overweight);
            Assert.AreEqual(weight - 35, result.WeightDeviation);
        }

        [Priority(1)]
        [TestCategory("labrador")]
        [TestMethod]
        public void ReturnsLifeExpectancy14IfBreedIsLabrador()
        {
            Assert.AreEqual(
                14, _dogMeasuresService.GetLifeExpectancy("Labrador Retriever"));
        }

        [Priority(2)]
        [TestCategory("beagle")]
        [TestMethod]
        public void DogIsInOverweight_IfBreedBeagleAndWeight20()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Beagle", 20);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.Overweight);
            Assert.AreEqual(6, result.WeightDeviation);
        }

        [Priority(2)]
        [TestCategory("beagle")]
        [TestProperty("BreedType", "Medium")]
        [TestMethod]
        public void DogIsInWeightRangeIfBreedBeagleAndWeight12()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Beagle", 12);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.InRange);
            Assert.AreEqual(0, result.WeightDeviation);
        }

        [Priority(2)]
        [TestCategory("beagle")]
        [TestMethod]
        public void DogIsBelowWeightIfBreedBeagleAndWeight5()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Beagle", 5);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.BelowWeight);
            Assert.AreEqual(3, result.WeightDeviation);
        }

        [TestCategory("boxer")]
        [TestMethod]
        public void DogIsInOverweightIfBreedBoxerAndWeight50()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Bóxer", 50);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.Overweight);
            Assert.AreEqual(10, result.WeightDeviation);
        }

        [TestCategory("boxer")]
        [TestMethod]
        public void DogIsInWeightRangeIfBreedBoxerAndWeight31()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Bóxer", 31);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.InRange);
            Assert.AreEqual(0, result.WeightDeviation);
        }

        [TestCategory("boxer")]
        [TestMethod]
        public void DogIsBelowWeightIfBreedBoxerAndWeight16()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Bóxer", 16);
            Assert.IsTrue(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.BelowWeight);
            Assert.AreEqual(4, result.WeightDeviation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowsArgumentOutOfRangeExceptionIfWeightIsNegative()
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Labrador Retriever", -5);
        }
    }
}
