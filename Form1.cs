using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class airbook : Form
    {
        public airbook()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            btn_book.Visible = false;
            groupBox1.Visible = false;
            //lblMessage.Visible = true;
        
        }

        private void lbl_lgnfirst_Click(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            }

        private void lbltoolStrip_login_Click(object sender, EventArgs e)
        {
            Login1 ss = new Login1();
            this.Hide();
            ss.Show();

        }

        private void lbltoolStrip_signup_Click(object sender, EventArgs e)
        {
            Signup1 s = new Signup1();
            this.Hide();
            s.Show();
        }

        private void Form1_airbook_Load(object sender, EventArgs e){
            label1.Text = Login1.userq;
            if (Login1.userq != ""){
                //lblMessage.Visible = false;
                groupBox1.Visible = true;
            }
            else
            {

            }

            String user = Login1.usr;
            String cnstr = Airline.Properties.Resources.cnstr;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\AIRLINEBOOKING.MDF;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
                    string qr = @"select count(*) from [dbo].[Signup] Where Username='p';";
                                                                                                                                    
            cmd = new SqlCommand(qr, con);
            int count = (int)cmd.ExecuteScalar();


            if (count > 0)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                MessageBox.Show("Please try Again");
            }
            con.Close();


        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows.ToString();
            MessageBox.Show("Now we need to create new form and create payment page there.");

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            String org = comboBox1.Text;
            String des = comboBox2.Text;

            String cnstr = Airline.Properties.Resources.cnstr;
            SqlConnection con = new SqlConnection(cnstr);
            SqlCommand cmd;
            dataGridView1.Visible = true;

            con.Open();
            string qr = @"select * from Flight WHERE Org ='" + org + "' AND Des='" + des + "'";

            //INSERT INTO [dbo].[Signup] ([Name], [Email], [Username], [Password], [Phone]) VALUES (1, N'', N'', N'', N'', CAST(7046 AS Decimal(18, 0)))
            cmd = new SqlCommand(qr, con);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = dt;
                dataGridView1.DataSource = bsource;
                btn_book.Visible = true;
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin xxx = new Admin();
            xxx.Show();
            this.Hide();
        }

        



    }
}
