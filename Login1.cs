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
    public partial class Login1 : Form
    {
        public static string userq = "";
        public static string extra = "";
        public static string usr = "";  
        public Login1()
        {
            InitializeComponent();
        }

        private void btn_lgn_Click(object sender, EventArgs e)
        {
            String user = txt_uname.Text;
            usr = user;
            String pwd = txt_pwd.Text;

            String cnstr = Airline.Properties.Resources.cnstr;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\AIRLINEBOOKING.MDF;Integrated Security=True");
            SqlCommand cmd;
            con.Open();
            //con = (@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\USERS\USER\DOCUMENTS\AIRLINEBOOKING.MDF;Integrated Security=True");
            string qr = @"select count(*) from [dbo].[Signup] Where Username='" + user + "';";
            //INSERT INTO [dbo].[Signup] ([Name], [Email], [Username], [Password], [Phone]) VALUES (1, N'', N'', N'', N'', CAST(7046 AS Decimal(18, 0)))
            cmd = new SqlCommand(qr, con);
            int count = (int)cmd.ExecuteScalar();


            if (count > 0)
            {
                MessageBox.Show("Login Successfull");
                userq = "Welcome Mr " + txt_uname.Text;
                airbook sq = new airbook();
                this.Hide();
                sq.Show();

            }
            else
            {
                MessageBox.Show("Please try Again");
            }
            con.Close();
        

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Signup1 sss = new Signup1();
            this.Hide();
            sss.Show();
        
        }
    }
}
