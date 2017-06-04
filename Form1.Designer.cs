namespace Airline
{
    partial class airbook
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbltoolStrip_login = new System.Windows.Forms.ToolStripLabel();
            this.lbltoolStrip_signup = new System.Windows.Forms.ToolStripLabel();
            this.lbl_lgnfirst = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_orgn = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_book = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbltoolStrip_login,
            this.lbltoolStrip_signup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 388);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(820, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lbltoolStrip_login
            // 
            this.lbltoolStrip_login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbltoolStrip_login.Name = "lbltoolStrip_login";
            this.lbltoolStrip_login.Size = new System.Drawing.Size(49, 22);
            this.lbltoolStrip_login.Text = "Login";
            this.lbltoolStrip_login.Click += new System.EventHandler(this.lbltoolStrip_login_Click);
            // 
            // lbltoolStrip_signup
            // 
            this.lbltoolStrip_signup.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbltoolStrip_signup.Name = "lbltoolStrip_signup";
            this.lbltoolStrip_signup.Size = new System.Drawing.Size(59, 22);
            this.lbltoolStrip_signup.Text = "Signup";
            this.lbltoolStrip_signup.Click += new System.EventHandler(this.lbltoolStrip_signup_Click);
            // 
            // lbl_lgnfirst
            // 
            this.lbl_lgnfirst.AutoSize = true;
            this.lbl_lgnfirst.Font = new System.Drawing.Font("Elephant", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lgnfirst.Location = new System.Drawing.Point(308, 20);
            this.lbl_lgnfirst.Name = "lbl_lgnfirst";
            this.lbl_lgnfirst.Size = new System.Drawing.Size(188, 38);
            this.lbl_lgnfirst.TabIndex = 1;
            this.lbl_lgnfirst.Text = "Login First";
            this.lbl_lgnfirst.Click += new System.EventHandler(this.lbl_lgnfirst_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(80, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Org";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Des";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PriceEco";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Special";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Duration";
            this.Column6.Name = "Column6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.lbl_from);
            this.groupBox1.Controls.Add(this.lbl_orgn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(80, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 56);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(594, 14);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 30);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ahmedabad",
            "Pune",
            "Nasik",
            "Delhi",
            "Keshod",
            "Mumbai",
            "Kolkata",
            "Bengaluru",
            "Noida",
            "Amritsar",
            "Varanasi",
            "Baroda",
            "Surat"});
            this.comboBox2.Location = new System.Drawing.Point(385, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(274, 15);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(90, 20);
            this.lbl_from.TabIndex = 9;
            this.lbl_from.Text = "Destination";
            // 
            // lbl_orgn
            // 
            this.lbl_orgn.AutoSize = true;
            this.lbl_orgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orgn.Location = new System.Drawing.Point(6, 19);
            this.lbl_orgn.Name = "lbl_orgn";
            this.lbl_orgn.Size = new System.Drawing.Size(50, 20);
            this.lbl_orgn.TabIndex = 8;
            this.lbl_orgn.Text = "Origin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ahmedabad",
            "Pune",
            "Nasik",
            "Delhi",
            "Keshod",
            "Mumbai",
            "Kolkata",
            "Bengaluru",
            "Noida",
            "Amritsar",
            "Varanasi",
            "Baroda",
            "Surat"});
            this.comboBox1.Location = new System.Drawing.Point(102, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // btn_book
            // 
            this.btn_book.Location = new System.Drawing.Point(279, 340);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(223, 23);
            this.btn_book.TabIndex = 10;
            this.btn_book.Text = "Book Ticket";
            this.btn_book.UseVisualStyleBackColor = true;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(80, 15);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // airbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 413);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_lgnfirst);
            this.Controls.Add(this.toolStrip1);
            this.Name = "airbook";
            this.Text = "Airline Booking";
            this.Load += new System.EventHandler(this.Form1_airbook_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lbltoolStrip_login;
        private System.Windows.Forms.ToolStripLabel lbltoolStrip_signup;
        private System.Windows.Forms.Label lbl_lgnfirst;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_orgn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnAdmin;
    }
}

