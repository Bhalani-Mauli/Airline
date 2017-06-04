namespace Airline
{
    partial class Login1
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
            this.lbl_uname = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.btn_lgn = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.Location = new System.Drawing.Point(26, 53);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(55, 13);
            this.lbl_uname.TabIndex = 0;
            this.lbl_uname.Text = "Username";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(26, 108);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(53, 13);
            this.lbl_pwd.TabIndex = 1;
            this.lbl_pwd.Text = "Password";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(111, 53);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(100, 20);
            this.txt_uname.TabIndex = 2;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(111, 101);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(100, 20);
            this.txt_pwd.TabIndex = 3;
            // 
            // btn_lgn
            // 
            this.btn_lgn.Location = new System.Drawing.Point(38, 165);
            this.btn_lgn.Name = "btn_lgn";
            this.btn_lgn.Size = new System.Drawing.Size(75, 23);
            this.btn_lgn.TabIndex = 4;
            this.btn_lgn.Text = "Login";
            this.btn_lgn.UseVisualStyleBackColor = true;
            this.btn_lgn.Click += new System.EventHandler(this.btn_lgn_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(136, 165);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "Signup";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.btn_lgn);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_uname);
            this.Name = "Login1";
            this.Text = "Login1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Button btn_lgn;
        private System.Windows.Forms.Button btn_signup;
    }
}