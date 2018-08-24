using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linkedin.DogMeasures.Services
{
    public class DogMeasuresService
    {
        private readonly List<Models.DogMeasures> _dogInfo;

        public DogMeasuresService()
        {
            _dogInfo = new List<Models.DogMeasures> {
                new Models.DogMeasures {
                    Breed = "Afgano",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Akita",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "American Bully",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "American Foxhound",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "American Pitbull Terrier",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Beagle",
                    RecommendedMinWeight = 8,
                    RecommendedMaxWeight = 14,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Bichón Frisé",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Bichón Maltés",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Bodeguero Andaluz",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Border Collie",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Border Terrier",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Bóxer",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 40,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Bulldog",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Caniche",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Chihuahua",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Chow Chow",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Golden Retriever",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 28,
                    LifeExpectancy = 14
                },
                new Models.DogMeasures {
                    Breed = "Labrador Retriever",
                    RecommendedMinWeight = 20,
                    RecommendedMaxWeight = 35,
                    LifeExpectancy = 14
                }
            };
        }
    }
}
