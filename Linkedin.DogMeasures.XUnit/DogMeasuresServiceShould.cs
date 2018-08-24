using Linkedin.DogMeasures.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linkedin.DogMeasures.XUnit
{
    public class DogMeasuresServiceShould
    {
        private DogMeasuresService _dogMeasuresService;

        public DogMeasuresServiceShould()
        {
            _dogMeasuresService = new DogMeasuresService();
        }
    }
}
