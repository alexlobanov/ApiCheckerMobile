using System;
namespace ApiChecker.Models
{
    public class TutorialItemModel
    {
        /// <summary>
        /// Image URL that will be showed on Tutorial background
        /// </summary>
        /// <value>The background image url for Tutorial</value>
        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }

        public bool IsExitButtonVisible { get; set; }
    }
}
