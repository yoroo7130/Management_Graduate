using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace A_오징어_EduMgr
{
    class Member
    {
        private DBManager conn = null;
        private DataSet dataSet = null;
        private int count = 0;

        public Member()
        {
            conn = new DBManager();            
        }

        // 로그인 정보 조회
        public DataSet SelectLogin(params string[] values)
        {
            string query = "SELECT userpwd FROM t_login WHERE userid = @param0";
            dataSet = conn.RowQuery(query, values);

            return dataSet;
        }

        // 개인 정보 조회
        public DataSet SelectUserInfo(params string[] values)
        {
            string query = "SELECT name, edunum, birth, email, phone FROM t_userinfo WHERE userid = @param0";
            dataSet = conn.RowQuery(query, values);

            return dataSet;
        }

        // 개인 정보 수정
        public int UpdateMember(params string[] values)
        {
            string query = "UPDATE t_userinfo SET birth = @param0 , email = @param1, phone = @param2 WHERE edunum = @param3";
            int count = conn.ExecQuery(query, values);

            return count;
        }

        // 회원탈퇴
        public int DeleteMember(params string[] values)
        {
            try
            {
                string edunum = null;
                string deleteQuery = null;

                string query = "SELECT edunum FROM t_userinfo WHERE userid = :param0";
                dataSet = conn.RowQuery(query, values);

                DataTable dt = dataSet.Tables[0];

                DataRow dr = dt.Rows[0];

                if (dt.Rows.Count != 0)
                {
                    edunum = dr["edunum"].ToString();
                    deleteQuery = "DELETE FROM t_userinfo WHERE userid = @param0";
                    if ((count = conn.ExecQuery(deleteQuery, values)) != 0)
                    {
                        deleteQuery = "DELETE FROM t_login WHERE userid = @param0";
                        if ((count = conn.ExecQuery(deleteQuery, values)) != 0)
                        {
                            deleteQuery = "DELETE FROM t_user_subject WHERE edunum = @param0";
                            return count = conn.ExecQuery(deleteQuery, edunum);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("DeleteMember_Error : " + e.Message);
            }
            return count;
        }

        //중복확인
        public DataSet InsertCheck(params string[] values)
        {
            string query = "SELECT * FROM t_login WHERE userid = @param0";
            dataSet = conn.RowQuery(query, values);

            return dataSet;
        }

        //비밀번호 찾기
        public DataSet SelectPwd(params string[] values)
        {
            string query = "SELECT userpwd FROM t_userinfo WHERE userid = @param0 AND edunum = @param1 AND name = @param2";
            dataSet = conn.RowQuery(query, values);

            return dataSet;
        }

        //회원조회
        public DataSet SelectMember(params string[] values)
        {
            string query = "SELECT userid FROM t_userinfo WHERE edunum = @param0 AND name = @param1";
            dataSet = conn.RowQuery(query, values);

            return dataSet;
        }
    }
}
