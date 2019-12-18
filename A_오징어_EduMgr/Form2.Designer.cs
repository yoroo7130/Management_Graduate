namespace A_오징어_EduMgr
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblEduNum = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.plGroup = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblMySubject = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.ListBox();
            this.lbMySubject = new System.Windows.Forms.ListBox();
            this.plGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름 : ";
            // 
            // lblEduNum
            // 
            this.lblEduNum.AutoSize = true;
            this.lblEduNum.Location = new System.Drawing.Point(205, 20);
            this.lblEduNum.Name = "lblEduNum";
            this.lblEduNum.Size = new System.Drawing.Size(41, 12);
            this.lblEduNum.TabIndex = 1;
            this.lblEduNum.Text = "학번 : ";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(352, 20);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(65, 12);
            this.lblBirth.TabIndex = 2;
            this.lblBirth.Text = "생년월일 : ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 64);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 12);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "이메일 : ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(261, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(53, 12);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "핸드폰 : ";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(408, 116);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(108, 23);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "학생 정보 수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(27, 33);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(251, 233);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(27, 33);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // plGroup
            // 
            this.plGroup.BackColor = System.Drawing.Color.White;
            this.plGroup.Controls.Add(this.lblName);
            this.plGroup.Controls.Add(this.lblEduNum);
            this.plGroup.Controls.Add(this.lblBirth);
            this.plGroup.Controls.Add(this.lblEmail);
            this.plGroup.Controls.Add(this.lblPhone);
            this.plGroup.Location = new System.Drawing.Point(12, 12);
            this.plGroup.Name = "plGroup";
            this.plGroup.Size = new System.Drawing.Size(504, 98);
            this.plGroup.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(408, 302);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "수강 신청 완료";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.White;
            this.lblSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubject.Location = new System.Drawing.Point(12, 143);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 14);
            this.lblSubject.TabIndex = 10;
            this.lblSubject.Text = "강의명";
            this.lblSubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMySubject
            // 
            this.lblMySubject.AutoSize = true;
            this.lblMySubject.BackColor = System.Drawing.Color.White;
            this.lblMySubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMySubject.Location = new System.Drawing.Point(293, 143);
            this.lblMySubject.Name = "lblMySubject";
            this.lblMySubject.Size = new System.Drawing.Size(59, 14);
            this.lblMySubject.TabIndex = 11;
            this.lblMySubject.Text = "수강 강의";
            this.lblMySubject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSubject
            // 
            this.lbSubject.FormattingEnabled = true;
            this.lbSubject.ItemHeight = 12;
            this.lbSubject.Location = new System.Drawing.Point(12, 160);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSubject.Size = new System.Drawing.Size(223, 136);
            this.lbSubject.TabIndex = 12;
            // 
            // lbMySubject
            // 
            this.lbMySubject.FormattingEnabled = true;
            this.lbMySubject.ItemHeight = 12;
            this.lbMySubject.Location = new System.Drawing.Point(293, 160);
            this.lbMySubject.Name = "lbMySubject";
            this.lbMySubject.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbMySubject.Size = new System.Drawing.Size(223, 136);
            this.lbMySubject.TabIndex = 13;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_오징어_EduMgr.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(530, 331);
            this.Controls.Add(this.lbMySubject);
            this.Controls.Add(this.lbSubject);
            this.Controls.Add(this.lblMySubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.plGroup);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학생정보";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.plGroup.ResumeLayout(false);
            this.plGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEduNum;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Panel plGroup;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblMySubject;
        private System.Windows.Forms.ListBox lbSubject;
        private System.Windows.Forms.ListBox lbMySubject;
    }
}