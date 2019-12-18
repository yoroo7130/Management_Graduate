using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace A_오징어_EduMgr
{
    class ProMember
    {
        private ProDBManager conn = null;        
        private DataSet dataSet = null;
        private int count = 0;

        public ProMember()
        {
            conn = new ProDBManager();            
        }

        // 로그인 정보 조회
        public DataSet SelectLogin(params string[] values)
        {            
            string procedure = "SelectLogin";
            dataSet = conn.RowQuery(procedure, values);

            return dataSet;
        }

        // 개인 정보 조회
        public DataSet SelectUserInfo(params string[] values)
        {            
            string procedure = "SelectUserInfo";
            dataSet = conn.RowQuery(procedure, values);

            return dataSet;
        }

        // 개인 정보 수정
        public int UpdateMember(params string[] values)
        {            
            string procedure = "UpdateMember";
            count = conn.ExecQuery(procedure, values);

            return count;
        }

        // 회원탈퇴
        public int DeleteMember(params string[] values)
        {            
            string procedure = "DeleteUserInfo";
            count = conn.ExecQuery(procedure, values);

            return count;
        }

        //회원가입
        public int InsertMember(params string[] values)
        {            
            string procedure = "InsertMember";
            count = conn.ExecQuery(procedure, values);

            return count;
        }

        //회원조회
        public DataSet SelectMember(params string[] values)
        {            
            string procedure = "SelectMember";
            dataSet = conn.RowQuery(procedure, values);

            return dataSet;
        }

        //중복확인
        public DataSet InsertCheck(params string[] values)
        {           
            string procedure = "InsertCheck";
            dataSet = conn.RowQuery(procedure, values);

            return dataSet;
        }

        //비밀번호 찾기
        public DataSet SelectPwd(params string[] values)
        {
            string procedure = "SelectPwd";
            dataSet = conn.RowQuery(procedure, values);

            return dataSet;
        }
    }
}
