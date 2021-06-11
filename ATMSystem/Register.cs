using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Code\PBO\ATMSystem\ATMSystem\User.mdf;Integrated Security=True");
        private void btRegister_Click(object sender, EventArgs e)
        {
            int blc = 0;
            if (tbName.Text == "" || tbAccNumb.Text == "" || tbPin.Text == "")
            {
                MessageBox.Show("Missing Information");
            }else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('"+ tbName.Text +"','" + tbAccNumb.Text + "' , '" + tbPin.Text + "', "+blc+")";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Account Created");
                    Con.Close();
                }catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}
