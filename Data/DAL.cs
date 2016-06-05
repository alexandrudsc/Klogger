
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Text;
using System;
using System.Data;
using System.Collections;

namespace Klogger
{
    namespace Data
    {
        class DAL
        {
            private static string CONNECTION_STRING = "Data Source=80.96.123.131/ora09;User Id=hr;Password=oracletest;";

            private static DAL dal;

            private static OracleConnection conn;

            private DAL() { }

            #region CONNECTION
            public static DAL GetInstance()
            {
                try
                {
                    if (dal == null)
                        Init();
                    if (conn == null || conn.State.Equals(ConnectionState.Closed))
                    {
                        conn = new OracleConnection(CONNECTION_STRING);
                        conn.Open();
                    }
                    return dal;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

            public static void Close()
            {
                if (conn != null)
                    conn.Close();
                dal = null;
            }

            private static void Init()
            {
                dal = new DAL();

            }

            #endregion

            private DataTable ExecStatement(String sqlCmd)
            {
                OracleDataAdapter oda = new OracleDataAdapter(sqlCmd, conn);

                DataTable dt = new DataTable();
                oda.Fill(dt);
                return dt;
            }

            #region INSERT
            public User addUser(User user)
            {
                if (user == null) return null;

                if (UserExists(user))
                    return UpdateUser(user);

                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("INSERT INTO " + DB.USERS_TABLE);
                sqlCmd.Append(" (id, username, password, id_country) ");
                sqlCmd.Append(" VALUES ");
                sqlCmd.Append(" (alex_seq_user.nextval" + ", '" + user.username + "', '" + user.passwd + "', " + user.id_country + " )");

                DataTable dt = ExecStatement(sqlCmd.ToString());
                if (dt == null)
                    return null;

                return user;
            }

            public Country AddCountry(Country c) 
            {
                if (c == null) return null;

                if (CountryExists(c))
                    return UpdateCountry(c);
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("INSERT INTO " + DB.COUNTRIES_TABLE);
                sqlCmd.Append(" (id, language, name )");
                sqlCmd.Append(" VALUES ");
                sqlCmd.Append(" (alex_seq_country.nextval " + ", '" + c.language + "', '" + c.name + "' )");

                DataTable dt = ExecStatement(sqlCmd.ToString());
                if (dt == null)
                    return null;
                return c;
            }

            public UserAction AddUserAction(UserAction act)
            {
                if (act == null)    return null;
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("INSERT INTO " + DB.USER_ACTIONS_TABLE);
                sqlCmd.Append(" (id, id_user, id_action, time, action_value )");
                sqlCmd.Append(" VALUES ");
                sqlCmd.Append(" (alex_seq_useraction.nextval " + ", '" +
                                act.id_user + "', '" +
                                1 + "' ,'" +
                                act.date.ToString("dd-MMM-yyyy hh:mm:ss") + "' , '" +
                                act.value + "')");

                DataTable dt = ExecStatement(sqlCmd.ToString());
                if (dt == null)
                    return null;
                return act;
            }
            #endregion

            #region UPDATES

            public User UpdateUser(User user)
            {
                if (user == null) return null;

                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append(" UPDATE " + DB.USERS_TABLE);
                sqlCmd.Append(" SET username = '").Append(user.username + "', ");
                sqlCmd.Append(" password = '").Append(user.passwd + "',");
                sqlCmd.Append(" id_country = ").Append(user.id_country + "");
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" id = ").Append(user.id + "");

                DataTable dt = ExecStatement(sqlCmd.ToString());
                if (dt == null)
                    return null;

                return user;
            }

            public Country UpdateCountry(Country country)
            {
                if (country == null) return null;

                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append(" UPDATE " + DB.COUNTRIES_TABLE);
                sqlCmd.Append(" SET name = '").Append(country.name + "', ");
                sqlCmd.Append(" language = '").Append(country.language + "' ");
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" id = ").Append(country.idx + "");

                DataTable dt = ExecStatement(sqlCmd.ToString());
                if (dt == null)
                    return null;

                return country;

            }

            #endregion

            #region SELECTS
            public bool UserExists(User user)
            {
                if (user == null) return false;
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                sqlCmd.Append(" WHERE id = ").Append(user.id);
                DataTable dt = ExecStatement(sqlCmd.ToString());
                return  dt != null && dt.Rows.Count != 0;
            }

            public bool CountryExists(Country c)
            {
                if (c == null) return false;
               
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.COUNTRIES_TABLE);
                sqlCmd.Append(" WHERE id = ").Append(c.idx);

                DataTable dt = ExecStatement(sqlCmd.ToString());
                return dt != null && dt.Rows.Count != 0;
            }


            public User Login(String username, String passwd)
            {
                if (username == null || passwd == null)
                    return null;
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" username = '" + username + "' ");
                sqlCmd.Append(" AND ");
                sqlCmd.Append(" password = '" + passwd + "'");
                DataTable dt = ExecStatement(sqlCmd.ToString());
                try
                {
                    return User.CreateUser(dt.Rows[0]);
                }
                catch
                {
                    return null;
                }
            }

            public User getUser(int id)
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" id = " + id);

                DataTable dt = ExecStatement(sqlCmd.ToString());
                return User.CreateUser(dt.Rows[0]);
            }

            public User getUser(String username, String passwd)
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" username = " + username);
                sqlCmd.Append(" passwd = " + passwd);
                DataTable rs = ExecStatement(sqlCmd.ToString());
                return User.CreateUser(rs.Rows[0]);
            }

            public ArrayList GetUsers()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                DataTable rs = ExecStatement(sqlCmd.ToString());
                return User.CreateListUsers(rs);
            }

            public ArrayList GetCountries()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.COUNTRIES_TABLE);
                sqlCmd.Append(" ORDER BY name ASC");
                DataTable rs = ExecStatement(sqlCmd.ToString());
                return Country.CreateListCountries(rs);
            }

            public DataTable GetUsersRaw()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                return ExecStatement(sqlCmd.ToString());

            }
            public DataTable GetCountriesRaw()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.COUNTRIES_TABLE);
                sqlCmd.Append(" ORDER BY name ASC");
                return ExecStatement(sqlCmd.ToString());
            }
            
            public DataTable GetUserActionsRaw()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USER_ACTIONS_TABLE);
                return ExecStatement(sqlCmd.ToString());
            }

            public DataTable GetActionsRaw()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.ACTIONS_TABLE);
                return ExecStatement(sqlCmd.ToString());
            }

            public DataTable GetDevicesRaw()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.DEVICES_TABLE);
                return ExecStatement(sqlCmd.ToString());
            }

            #endregion

            #region DELETE
            public bool DeleteCountry(Country c)
            {
                if (c == null) return false;
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("DELETE FROM " + DB.COUNTRIES_TABLE);
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" id = ").Append(c.idx);
                ExecStatement(sqlCmd.ToString());
                return true;
            }

            public bool DeleteUser(User u)
            {
                if (u == null || u.id == 0) return false;

                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("DELETE FROM " + DB.USERS_TABLE);
                sqlCmd.Append(" WHERE ");
                sqlCmd.Append(" id = ").Append(u.id);
                ExecStatement(sqlCmd.ToString());
                return true;
            }

            #endregion

            #region COMPLEX QUERIES
            
            public UserAction MostUsedAction(User user)
            {
                if (user == null) return null;

            }

            #endregion

        }
    }
}
