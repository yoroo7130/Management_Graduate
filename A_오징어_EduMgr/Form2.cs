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
    public partial class Form2 : Form
    {
        private DataSet dataSet = null;

        private ProMember member = null;
        private ProSubject subject = null;
        //private OraMember member = null;
        //private OraSubject subject = null;

        private string EduNum = null;
        List<string> subtmp = new List<string>();
        public string UserId { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            member = new ProMember();
            subject = new ProSubject();

            //member = new OraMember();
            //subject = new OraSubject();

            DataLoad();
            SubjectLoad();
        }

        private void DataLoad()
        {
            try
            {
                dataSet = member.SelectUserInfo(UserId);

                DataTable dt = dataSet.Tables[0];

                DataRow dr = dt.Rows[0];

                EduNum = dr["edunum"].ToString();

                this.lblName.Text = "이름 : " + dr["name"].ToString();
                this.lblEduNum.Text = "학번 : " + EduNum;
                this.lblBirth.Text = "생년월일 : " + dr["birth"].ToString();
                this.lblEmail.Text = "이메일 : " + dr["email"].ToString();
                this.lblPhone.Text = "핸드폰 : " + dr["phone"].ToString();

                dataSet = subject.SelectSubject(EduNum);

                dt = dataSet.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        subtmp.Add(item.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("DataLoad_Error : " + e.Message);
            }
        }

        private void SubjectLoad()
        {
            dataSet = subject.SelectSubject();

            DataTable dt = dataSet.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (!subtmp.Contains(item.ToString()))
                        this.lbSubject.Items.Add(item.ToString());
                }
            }

            foreach (string s in subtmp)
                this.lbMySubject.Items.Add(s);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.EudNum = Convert.ToInt32(EduNum);
            frm3.UserId = UserId;
            if (frm3.ShowDialog() == DialogResult.OK)
            {
                DataLoad();
                frm3.Close();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            subtmp.Clear();
            foreach (string s in lbSubject.SelectedItems)
            {
                this.lbMySubject.Items.Add(s);
                subtmp.Add(s);
            }
            foreach (string s in subtmp)
            {
                this.lbSubject.Items.Remove(s);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            subtmp.Clear();
            foreach (string s in lbMySubject.SelectedItems)
            {
                this.lbSubject.Items.Add(s);
                subtmp.Add(s);
            }
            foreach (string s in subtmp)
            {
                this.lbMySubject.Items.Remove(s);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                subject.DeleteSubject(EduNum);

                foreach (string sub in this.lbMySubject.Items)
                {
                    subject.InsertSubject(EduNum, sub);
                }
                MessageBox.Show("데이터가 저장 되었습니다.", "알람", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("데이터가 저장 되지 않았습니다.", "알람",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}