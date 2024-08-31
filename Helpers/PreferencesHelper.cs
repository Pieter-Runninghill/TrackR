using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackR.Helpers
{
    public static class PreferencesHelper
    {
        private const string UserIdKey = "UserId";

        public static void SaveUserId(string userId)
        {
            Preferences.Set(UserIdKey, userId);
        }

        public static string GetUserId()
        {
            return Preferences.Get(UserIdKey, string.Empty);
        }

        public static void ClearUserId()
        {
            Preferences.Remove(UserIdKey);
        }
    }

}
