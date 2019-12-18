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
    public partial class Form5 : Form
    {
        private DataSet dataSet = null;
        private ProMember member = null;
        //private OraMember member = null;

        public Form5()
        {
            InitializeComponent();
            txtEduNum.Select();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            member = new ProMember();
            //member = new OraMember();
        }

        private void DataLoad()
        {
            try
            {
                dataSet = member.SelectMember(txtEduNum.Text, txtName.Text);

                DataTable dt = dataSet.Tables[0];

                DataRow dr = dt.Rows[0];

                txtId.Text = dr["userid"].ToString();
            }
            catch
            {
                MessageBox.Show("시스템에 등록된 정보와 일치하지 않습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form5"].Close();
        }
    }
}
