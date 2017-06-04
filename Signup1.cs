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
    public partial class Signup1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\AIRLINEBOOKING.MDF;Integrated Security=True");
        SqlCommand cmd;
        public Signup1()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            String name, email, username, pass, phone;
            name = txtName.Text;
            email = txtEmail.Text;
            username = txtUser.Text;
            pass = txtPwd.Text;
            phone = txtPhone.Text;
            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Signup ( [Name], [Email], [Username], [Password], [Phone]) VALUES ('" + name + "','" + email + "','" + username + "','" + pass + "'," + phone + ")",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Inserted  Succuessfully.......");
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void lbl_uname_Click(object sender, EventArgs e)
        {

        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {
            Login1 ss = new Login1();
            this.Hide();
            ss.Show();
        }
    }
}
