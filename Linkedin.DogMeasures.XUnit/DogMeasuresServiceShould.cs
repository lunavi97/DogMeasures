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
    }
}
