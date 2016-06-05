using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klogger
{
    namespace Data
    {
        class DB
        {
            public static string USERS_TABLE = "alex_users";
            public static string COUNTRIES_TABLE = "alex_countries";
            public static string USER_ACTIONS_TABLE = "alex_user_actions";
            public static string ACTIONS_TABLE = "alex_actions";
            public static string DEVICES_TABLE = "alex_devices";


            public const int USER_USERNAME = 0;
            public const int USER_PASSWD = 1;
            public const int USER_ID = 2;
            public const int USER_ID_COUNTRY = 3;

            public const int COUNTRY_ID = 0;
            public const int COUNTRY_LANGUAGE = 1;
            public const int COUNTRY_NAME = 2;

            public const int USER_ACTIONS_ID = 0;
            public const int USER_ACTIONS_USERID = 1;
            public const int USER_ACTIONS_ACTIONID = 2;
            public const int USER_ACTIONS_TIME = 3;
            public const int USER_ACTIONS_VALUE = 4;

            public const int ACTION_ID = 0;
            public const int BUTTON_CODE = 1;
            public const int ACTION_DEVICE_ID = 2;

            public const int DEVICES_ID = 0;
            public const int DEVICES_NAME = 1;

        }
    }
}
