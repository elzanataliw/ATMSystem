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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Code\PBO\ATMSystem\ATMSystem\User.mdf;Integrated Security=True");
        string Acc = Login.AccNumb;
        int oldBalance, newbalance;
        private void btQuit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        private void btDeposit_Click(object sender, EventArgs e)
        {
            if(tbDeposit.Text == "" || Convert.ToInt32(tbDeposit.Text) <= 0)
            {
                MessageBox.Show("Enter the Amount to Deposit");
            }
            else
            {
                newbalance = oldBalance + Convert.ToInt32(tbDeposit.Text);
                try
                {
                    Con.Open();
                    string query = "update UserTbl set Balance = " + newbalance + " where AccNumb='" + Acc + "' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit");
                    Con.Close();
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void GetBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from UserTbl where AccNumb = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldBalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void Deposit_Load(object sender, EventArgs e)
        {
            GetBalance();
        }
    }
}
