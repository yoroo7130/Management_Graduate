using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace A_오징어_EduMgr
{
    class Subject
    {
        private DBManager conn = null;        
        private DataSet dataSet = null;

        public Subject()
        {
            conn = new DBManager();
        }

        // 수강 신청 목록 조회
        public DataSet SelectSubject(params string[] values)
        {            
            string query = "SELECT subject FROM t_user_subject WHERE edunum = @param0";
            dataSet = conn.RowQuery(query, values);
            
            return dataSet;
        }

        // 수강 목록 조회
        public DataSet SelectSubject()
        {            
            string query = "SELECT subject FROM t_subject";
            dataSet = conn.RowQuery(query);

            return dataSet;
        }

        // 수강 신청 삽입
        public int InsertSubject(params string[] values)
        {            
            string query = "INSERT INTO t_user_subject(edunum, subject) VALUES(@param0, @param1)";
            int count = conn.ExecQuery(query, values);

            return count;
        }

        // 수강 신청 삭제
        public int DeleteSubject(params string[] values)
        {            
            string query = "DELETE FROM t_user_subject WHERE edunum = @param0";
            int count = conn.ExecQuery(query, values);

            return count;
        }
    }
}
