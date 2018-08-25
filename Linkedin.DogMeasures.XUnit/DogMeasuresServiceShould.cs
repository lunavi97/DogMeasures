using Linkedin.DogMeasures.Exceptions;
using Linkedin.DogMeasures.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Linkedin.DogMeasures.XUnit
{
    public class DogMeasuresServiceShould
    {
        private DogMeasuresService _dogMeasuresService;

        public DogMeasuresServiceShould()
        {
            _dogMeasuresService = new DogMeasuresService();
        }

        [Fact]
        public void ThrowsArgumentNullExceptionIfBreedIsNull()
        {
            Assert.Throws<ArgumentNullException>(
                () => _dogMeasuresService.CheckDogIdealWeight(null, 0));
        }

        [Fact]
        public void ThrowsBreedNotExceptionIfBreedIsSamoyedo()
        {
            Assert.Throws<BreedNotFoundException>(
                () => _dogMeasuresService.CheckDogIdealWeight("Samoyedo", 20));
        }

        [Fact]
        public void ThrowsArgumentOutOfRangeExceptionIfLengthIsNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => _dogMeasuresService.CheckDogIdealWeight("Caniche", -5));
        }

        [InlineData(20)]
        [InlineData(21)]
        [InlineData(22)]
        [InlineData(23)]
        [InlineData(24)]
        [InlineData(25)]
        [InlineData(26)]
        [InlineData(27)]
        [InlineData(28)]
        [InlineData(29)]
        [InlineData(30)]
        [InlineData(31)]
        [InlineData(32)]
        [InlineData(33)]
        [InlineData(34)]
        [InlineData(35)]
        [Theory]
        public void DogIsInIdealWeightIfBreedIsLabradorAndWeightInRange20And35(
            int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight(
                "Labrador Retriever", weight);
            Assert.True(result.DeviationType == Models.DogWeightInfo.WeightDeviationType.InRange);
            Assert.Equal(0, result.WeightDeviation);
        }

        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(9)]
        [InlineData(10)]
        [InlineData(11)]
        [InlineData(12)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(15)]
        [InlineData(16)]
        [InlineData(17)]
        [InlineData(18)]
        [InlineData(19)]
        [Theory]
        public void DogIsBelowWeightIfBreedIsLabradorAndWeightInRange5And19(int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Labrador Retriever", weight);
            Assert.True(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.BelowWeight);
            Assert.Equal(20 - weight, result.WeightDeviation);
        }

        [InlineData(36)]
        [InlineData(37)]
        [InlineData(38)]
        [InlineData(39)]
        [InlineData(40)]
        [Theory]
        public void DogIsOverWeightIfBreedIsLabradorAndWeightInRange36And40(int weight)
        {
            var result = _dogMeasuresService.CheckDogIdealWeight("Labrador Retriever", weight);
            Assert.True(
                result.DeviationType == Models.DogWeightInfo.WeightDeviationType.Overweight);
            Assert.Equal(weight - 35, result.WeightDeviation);
        }

        [Fact]
        public void ReturnsLifeExpectancy14IfBreedIsLabrador()
        {
            Assert.Equal(14, _dogMeasuresService.GetLifeExpectancy("Labrador Retriever"));
        }
    }
}
