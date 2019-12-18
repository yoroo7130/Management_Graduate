using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace A_오징어_EduMgr
{
    class ProSubject
    {
        private ProDBManager conn = null;        
        private DataSet dataSet = null;
        private int count = 0;

        public ProSubject()
        {
            conn = new ProDBManager();
        }

        // 수강 신청 목록 조회
        public DataSet SelectSubject(params string[] values)
        {            
            string procedure = "SelectSubjectInfo";
            dataSet = conn.RowQuery(procedure, values);
            
            return dataSet;
        }

        // 수강 목록 조회
        public DataSet SelectSubject()
        {            
            string procedure = "SelectSubject";
            dataSet = conn.RowQuery(procedure);

            return dataSet;
        }

        // 수강 신청 삽입
        public int InsertSubject(params string[] values)
        {           
            string procedure = "InsertSubject";
            count = conn.ExecQuery(procedure, values);

            return count;
        }

        // 수강 신청 삭제
        public int DeleteSubject(params string[] values)
        {            
            string procedure = "DeleteSubject";
            count = conn.ExecQuery(procedure, values);

            return count;
        }
    }
}
