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

namespace ATMSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btRegist_Click(object sender, EventArgs e)
        {
            Register regist = new Register();
            regist.Show();
            this.Hide();
        }
        public static string AccNumb;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Code\PBO\ATMSystem\ATMSystem\User.mdf;Integrated Security=True");
        private void btLogIn_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(" select count(*) from UserTbl where AccNumb =" + tbAccNumb.Text + " and Pin = " + tbPin.Text + "", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString() == "1")
            {
                AccNumb = tbAccNumb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong Account Number or PIN");
            }
            Con.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
