using System;
using System.Collections.Generic;
using ApiChecker.Models;
using ApiChecker.Repository.Interfaces;

namespace ApiChecker.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        public IEnumerable<TutorialItemModel> GetTutorialGuides()
        {
            return new List<TutorialItemModel>()
            {
                new TutorialItemModel
                {
                    ImageUrl = "stock1.jpg",
                    Title = "Welcome",
                    Subtitle = "WebSite Latency Verifier",
                    Text = "This application will help you to ensure that you website or service available around the globe.",
                    IsExitButtonVisible = false
                },
                new TutorialItemModel
                {
                    ImageUrl = "stock2.jpg",
                    Title = "Your Service Availability",
                    Subtitle = "around the globe",
                    Text = "Let's verify if you website is always avalible for your customers. This applicaiton using only open API for ApiChecker. If you want to monitor your services every minute - just register at ApiChecker.com",
                    IsExitButtonVisible = true
                },
            };
        }
    }
}
