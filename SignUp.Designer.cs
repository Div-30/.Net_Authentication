namespace THURSDAY_APP
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SIGN UP PAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "FullName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fullNameBox
            // 
            this.fullNameBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameBox.Location = new System.Drawing.Point(57, 109);
            this.fullNameBox.Name = "fullNameBox";
            this.fullNameBox.Size = new System.Drawing.Size(257, 29);
            this.fullNameBox.TabIndex = 2;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(59, 202);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(256, 29);
            this.emailBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // passwordBox
            // 
            this.passwordBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(58, 293);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(256, 29);
            this.passwordBox.TabIndex = 6;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(55, 260);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(82, 21);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // signUpBtn
            // 
            this.signUpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(58, 401);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(104, 33);
            this.signUpBtn.TabIndex = 7;
            this.signUpBtn.Text = "SignUp";
            this.signUpBtn.UseVisualStyleBackColor = false;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(56, 355);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(231, 40);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Already have an account?Login\r\n\r\n";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 474);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}