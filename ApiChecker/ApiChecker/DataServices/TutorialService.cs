using System;
using System.Collections.Generic;
using ApiChecker.DataServices.Interfaces;
using ApiChecker.Models;

namespace ApiChecker.DataServices
{
    public class TutorialService : ITutorialService
    {
        public TutorialService()
        {
        }

        public IEnumerable<TutorialItemModel> GetTutorialGuides()
        {
            return new List<TutorialItemModel>()
            {
                new TutorialItemModel
                {
                    ImageUrl = "stock1.jpg",
                    Title = "Welcome",
                    Subtitle = "TO THIS TASTEFUL LOOKING TUTORIAL",
                    Text = "Just look at that awesome plate filled with tomatoes, rucola and some sort of white coleslaw looking thing. I don't like coleslaw. Really don't.",
                    IsExitButtonVisible = false
                },
                new TutorialItemModel
                {
                    ImageUrl = "stock2.jpg",
                    Title = "Churros!",
                    Subtitle = "YOU GOTTA LOVE THESE",
                    Text = "Churros oh churros, my favorite cakes, dipped in cinnamon and oh so sweet. Some are long, some are short, but they are all tasty and that's why I love them.",
                    IsExitButtonVisible = true
                },
            };
        }
    }
}
