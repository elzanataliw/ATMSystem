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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Code\PBO\ATMSystem\ATMSystem\User.mdf;Integrated Security=True");
        string Acc = Login.AccNumb;
        private void btChange_Click(object sender, EventArgs e)
        {
            if (tbNewpin.Text == "" || tbConfirm.Text == "")
            {
                MessageBox.Show("Enter and Confirm the new pin");
            }
            else if (tbConfirm.Text != tbNewpin.Text)
            {
                MessageBox.Show("Pin and Confirm are different");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set Pin = " + tbNewpin.Text + " where AccNumb='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pin successfully updated");
                    Con.Close();
                    Login log = new Login();
                    log.Show();
                    this.Hide();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void btQuit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
