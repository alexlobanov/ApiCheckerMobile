using System;
using System.Collections.Generic;
using ApiChecker.Models;

namespace ApiChecker.Repository.Interfaces
{
    public interface ITutorialRepository
    {
        IEnumerable<TutorialItemModel> GetTutorialGuides();
    }
}
