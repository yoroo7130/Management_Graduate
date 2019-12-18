using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace A_오징어_EduMgr {

    class OraDBManager
    {
        OracleConnection conn = null;

        // DB ip
        static private string dbIp = "127.0.0.1";

        // DB sid
        static private string dbName = "mydb";

        // DB id
        static private string dbId = "park";

        // DB pwd
        static private string dbPw = "1429";

        public OracleConnection OraDBConnector(string dbIp, string dbName, string dbId, string dbPw)
        {

            conn = new OracleConnection($"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={dbIp})(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={dbName})));User ID={dbId};Password={dbPw};");
            
            conn.Open();

            return conn;
        }

        // SELECT
        public DataSet RowQuery(string query, params string[] values)
        {
            try
            {
                using (conn = OraDBConnector(dbIp, dbName, dbId, dbPw))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter())
                        {
                            sqlDataAdapter.SelectCommand = cmd;

                            var OraParams = new OracleParameter[values.Length];

                            if (OraParams.Length > 0)
                            {
                                for (int i = 0; i < values.Length; i++)
                                {
                                    cmd.Parameters.Add(new OracleParameter(string.Format(":param{0}", i), values[i]));
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
                using (conn = OraDBConnector(dbIp, dbName, dbId, dbPw))
                {
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataAdapter sqlDataAdapter = new OracleDataAdapter())
                        {
                            sqlDataAdapter.SelectCommand = cmd;

                            var OraParams = new OracleParameter[values.Length];

                            if (OraParams.Length > 0)
                            {
                                for (int i = 0; i < values.Length; i++)
                                {
                                    cmd.Parameters.Add(new OracleParameter(string.Format(":param{0}", i), values[i]));
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
                // 수정 에러 발생
                Console.WriteLine("ExecQuery_Error : " + e.Message);
                return 0;
            }
        }
    }
}
