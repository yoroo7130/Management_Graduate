namespace A_오징어_EduMgr
{
    partial class Form3
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
            this.lblEduNum = new System.Windows.Forms.Label();
            this.txtEduNum = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnDeleteInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEduNum
            // 
            this.lblEduNum.AutoSize = true;
            this.lblEduNum.BackColor = System.Drawing.Color.Transparent;
            this.lblEduNum.Location = new System.Drawing.Point(15, 18);
            this.lblEduNum.Name = "lblEduNum";
            this.lblEduNum.Size = new System.Drawing.Size(29, 12);
            this.lblEduNum.TabIndex = 0;
            this.lblEduNum.Text = "학번";
            // 
            // txtEduNum
            // 
            this.txtEduNum.Location = new System.Drawing.Point(74, 15);
            this.txtEduNum.Name = "txtEduNum";
            this.txtEduNum.ReadOnly = true;
            this.txtEduNum.Size = new System.Drawing.Size(173, 21);
            this.txtEduNum.TabIndex = 1;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(166, 150);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(81, 23);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.Location = new System.Drawing.Point(15, 45);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(29, 12);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "이름";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(74, 42);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(173, 21);
            this.txtName.TabIndex = 1;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.BackColor = System.Drawing.Color.Transparent;
            this.lblBirth.Location = new System.Drawing.Point(15, 72);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(53, 12);
            this.lblBirth.TabIndex = 0;
            this.lblBirth.Text = "생년월일";
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(74, 69);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(173, 21);
            this.txtBirth.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(15, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "이메일";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 21);
            this.txtEmail.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(15, 126);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 12);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "핸드폰";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(74, 123);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(173, 21);
            this.txtPhone.TabIndex = 1;
            // 
            // btnDeleteInfo
            // 
            this.btnDeleteInfo.Location = new System.Drawing.Point(74, 150);
            this.btnDeleteInfo.Name = "btnDeleteInfo";
            this.btnDeleteInfo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteInfo.TabIndex = 3;
            this.btnDeleteInfo.Text = "탈퇴";
            this.btnDeleteInfo.UseVisualStyleBackColor = true;
            this.btnDeleteInfo.Click += new System.EventHandler(this.btnDeleteInfo_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A_오징어_EduMgr.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(263, 187);
            this.Controls.Add(this.btnDeleteInfo);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.txtEduNum);
            this.Controls.Add(this.lblEduNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "학생정보 수정";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEduNum;
        private System.Windows.Forms.TextBox txtEduNum;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnDeleteInfo;
    }
}