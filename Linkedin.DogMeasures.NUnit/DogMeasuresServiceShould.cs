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
    }
}
