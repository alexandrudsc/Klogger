
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

            public static DAL GetInstance()
            {
                try
                {
                    if (dal == null)
                        Init();
                    return dal;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }

            private static void Init()
            {
                dal = new DAL();
                if (conn == null)
                {
                    conn = new OracleConnection(CONNECTION_STRING);
                }
            }
            private DataTable ExecStatement(String sqlCmd)
            {
                OracleDataAdapter oda = new OracleDataAdapter(sqlCmd, conn);

                // Utilizare DataAdapter pentru a seta datele intr-un DataTable
                DataTable dt = new DataTable();
                oda.Fill(dt);
                return dt;
            }

            public User addUser(User user)
            {

                if (user == null) return null;

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

            public DataTable GetUsersRaw()
            {
                StringBuilder sqlCmd = new StringBuilder();
                sqlCmd.Append("SELECT * FROM " + DB.USERS_TABLE);
                return ExecStatement(sqlCmd.ToString());

            }
        }
    }
}
