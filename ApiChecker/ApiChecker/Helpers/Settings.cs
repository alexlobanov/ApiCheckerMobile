using System;
using Xamarin.Essentials;

namespace ApiChecker.Helpers
{
    public static class Settings
    {
        private const string LastCheckedServiceKey = "last_check_service_key";
        private static readonly string LastCheckedServiceDefault = "";

        private const string IsTutorialCompletedKey = "is_tutorial_completed_key";
        private static readonly bool IsTutorialCompletedKeyDefault = false;


        public static string LastCheckedService
        {
            get
            {
                return Preferences.Get(LastCheckedServiceKey, LastCheckedServiceDefault);
            }
            set
            {
                Preferences.Set(LastCheckedServiceKey, value);
            }
        }


        public static bool IsTutorialCompleted
        {
            get
            {
                return Preferences.Get(IsTutorialCompletedKey, IsTutorialCompletedKeyDefault);
            }
            set
            {
                Preferences.Set(IsTutorialCompletedKey, value);
            }
        }
    }
}
