using System.Collections;
using System;
using ApiChecker.Models;
using System.Collections.Generic;

namespace ApiChecker.DataServices.Interfaces
{
    public interface ITutorialService
    {
        IEnumerable<TutorialItemModel> GetTutorialGuides();
    }
}
