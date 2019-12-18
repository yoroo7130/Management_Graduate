using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_오징어_EduMgr
{
    public partial class Form1 : Form
    {
        private DataSet dataSet = null;
        private ProMember member = null;
        //private OraMember member = null;
        private Boolean isLoginChk = true;

        public Form1()
        {
            InitializeComponent();
            txtId.Select();
        }

        public Boolean LoginChk(string userid, string userpwd)
        {
            try
            {
                member = new ProMember();
                //member = new OraMember(); 
                dataSet = member.SelectLogin(userid);

                DataTable dt = dataSet.Tables[0];

                DataRow dr = dt.Rows[0];

                if (dr["userpwd"].ToString() == userpwd)
                {
                    isLoginChk = true;
                }
                else
                {
                    isLoginChk = false;
                }
            }
            catch
            {
                txtClear();
                MessageBox.Show("아이디 또는 비밀번호가 다릅니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isLoginChk = false;
            }
            return isLoginChk;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(this.txtId.Text != "" && this.txtPwd.Text != "")
            {
                LoginChk(this.txtId.Text, this.txtPwd.Text);

                // 로그인 성공
                if (isLoginChk == true)
                {
                    Form2 frm2 = new Form2();
                    frm2.UserId = this.txtId.Text;
                    frm2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호를 입력하세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isLoginChk = false;
            }
        }

        private void txtClear()
        {
            this.txtId.Text = "";
            this.txtPwd.Text = "";
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}