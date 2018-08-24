﻿using System;

namespace Linkedin.DogMeasures.Exceptions
{
    public class BreedNotFoundException : Exception
    {
        public BreedNotFoundException()
        {
        }

        public BreedNotFoundException(string message) : base(message)
        {
        }
    }
}