using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace A_오징어_EduMgr
{
    public partial class Form3 : Form
    {
        private DataSet dataSet = null;

        private ProMember member = null;
        //private OraMember member = null;

        public int EudNum { get; set; }
        public string UserId { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (txtBirth.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                int count = member.UpdateMember(txtBirth.Text, txtEmail.Text, txtPhone.Text, EudNum.ToString());

                if (count == 1) DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("항목에는 공백이 입력될 수 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            member = new ProMember();
            //member = new OraMember();

            txtBirth.Select();

            dataSet = member.SelectUserInfo(UserId);

            DataTable dt = dataSet.Tables[0];

            DataRow dr = dt.Rows[0];

            this.txtName.Text = dr["name"].ToString();
            this.txtEduNum.Text = dr["edunum"].ToString();
            this.txtBirth.Text = dr["birth"].ToString();
            this.txtEmail.Text = dr["email"].ToString();
            this.txtPhone.Text = dr["phone"].ToString();
        }

        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("회원 탈퇴 하시겠습니까?", "회원탈퇴", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int count = member.DeleteMember(UserId);
                if (MessageBox.Show("회원 탈퇴가 완료되었습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    Application.OpenForms["Form1"].Close();
                    Application.OpenForms["Form2"].Close();
                }
            }
        }
    }
}