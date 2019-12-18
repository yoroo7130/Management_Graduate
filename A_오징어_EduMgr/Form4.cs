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
    public partial class Form4 : Form
    {
        private ProMember member = null;
        //private OraMember member = null;

        private DataSet dataSet = null;

        private int count = 0;
        private Boolean isValidIDCheck;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            member = new ProMember();
            //member = new OraMember();
            isValidIDCheck = false;

            txtId.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidIDCheck == true)
                {
                    if (txtId.Text != "" && txtPwd.Text != "" && txtEduNum.Text != "" && txtEmail.Text != "" &&
                        txtBirth.Text != "" && txtPhone.Text != "" && txtName.Text != "")
                    {
                        // 프로시저 사용시
                        member.InsertMember(txtId.Text, txtPwd.Text, txtEduNum.Text, txtName.Text, txtBirth.Text, txtEmail.Text, txtPhone.Text);

                        // 쿼리문 사용시
                        /*
                        int count = member.InsertMemberInfo(this.txtId.Text, this.txtEduNum.Text, this.txtName.Text, this.txtBirth.Text, this.txtEmail.Text, this.txtPhone.Text);

                        if (count == 1)
                        {
                            member.InsertMemberLogin(this.txtId.Text, this.txtPwd.Text);
                        }
                        */

                        if (MessageBox.Show("회원가입이 완료되었습니다.", "알림", MessageBoxButtons.OK,
                        MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            Application.OpenForms["Form4"].Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("모든 항목은 공백이 될 수 없습니다.", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("아이디를 중복확인 하세요.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("회원가입이 완료되지 않았습니다.", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form4"].Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataSet = member.InsertCheck(txtId.Text);

            DataTable dt = dataSet.Tables[0];

            count = dt.Rows.Count;

            if (!(string.IsNullOrEmpty(txtId.Text)))
            {
                if (count == 0)
                {
                    MessageBox.Show("사용가능한 아이디 입니다.", "알림", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    isValidIDCheck = true;
                }
                else
                {
                    MessageBox.Show("사용중인 아이디 입니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValidIDCheck = false;
                }
            }
            else
            {
                MessageBox.Show("아이디를 입력하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            isValidIDCheck = false;
        }

        private void txtEduNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyTypingNumber(e);
        }

        public void OnlyTypingNumber(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}

