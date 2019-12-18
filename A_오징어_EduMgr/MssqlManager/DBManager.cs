using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace A_오징어_EduMgr
{
    class DBManager
    {
        private SqlConnection conn = null;

        // DB ip
        static private string strIP = "127.0.0.1";

        // DB id
        static private string strID = "park";

        // DB pwd
        static private string strPW = "1429";

        // DB name
        static private string strName = "YUHAN";

        // DB 연결
        public SqlConnection DBConnector()
        {
            // 윈도우 인증 계정일 경우엔
            //sqlConnection = new SqlConnection("Server= localhost; Database= dbName Integrated Security = True;");

            // 로그인 인증
            string conStr = "server=" + strIP + "; uid=" + strID + "; pwd=" + strPW + "; database=" + strName;
            conn = new SqlConnection(conStr);

            if (conn != null && conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }

        // SELECT
        public DataSet RowQuery(string query, params string[] values)
        {
            try
            {
                using (conn = DBConnector())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                        {
                            sqlDataAdapter.SelectCommand = cmd;

                            var _params = new string[values.Length];

                            if (_params.Length > 0)
                            {
                                for (int i = 0; i < values.Length; i++)
                                {
                                    _params[i] = string.Format("@param{0}", i);
                                    cmd.Parameters.AddWithValue(_params[i], values[i]);
                                }
                            }

                            DataSet dataSet = new DataSet();

                            sqlDataAdapter.Fill(dataSet);

                            conn.Close();

                            return dataSet;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                // 조회 에러 발생
                Console.WriteLine("RowQuery_Error : " + e.Message);
                return null;
            }
        }

        // INSERT, UPDATE, DELETE
        public int ExecQuery(string query, params string[] values)
        {
            try
            {
                using (conn = DBConnector())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                        {
                            sqlDataAdapter.SelectCommand = cmd;

                            var _params = new string[values.Length];

                            if (_params.Length > 0)
                            {
                                for (int i = 0; i < values.Length; i++)
                                {
                                    _params[i] = string.Format("@param{0}", i);
                                    cmd.Parameters.AddWithValue(_params[i], values[i]);
                                }
                            }

                            int count = cmd.ExecuteNonQuery();

                            conn.Close();

                            return count;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ExecQuery_Error : " + e.Message);
                return 0;
            }
        }
    }
}
