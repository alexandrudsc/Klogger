using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;

namespace Klogger
{
    namespace Data
    {
        public class User
        {
            public int id ;
            public String username;
            public String passwd;
            public int id_country;
            
            public static User CreateUser(DataRow rs)
            {
                if (rs == null) return null;
                try
                {
                    User user = new User();
                    user.id = int.Parse(rs[DB.USER_ID].ToString());
                    user.username = rs[DB.USER_USERNAME].ToString();
                    user.passwd = rs[DB.USER_PASSWD].ToString();
                    user.id_country = int.Parse(rs[DB.USER_ID_COUNTRY].ToString());
                    return user;
                }
                catch 
                {

                    return null;
                }
            }

            public static ArrayList CreateListUsers(DataTable rs)
            {
                ArrayList list = new ArrayList();
                try
                {
                    if (rs == null) return null;

                    foreach (DataRow row in rs.Rows)
                        list.Add(User.CreateUser(row));
                }
                catch 
                {
                    return null;
                }
                return list;
            }
        }
    }
}
