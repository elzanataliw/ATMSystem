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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.Code\PBO\ATMSystem\ATMSystem\User.mdf;Integrated Security=True");
        string Acc = Login.AccNumb;
        int blc;
        int oldbalance, newbalance;

        private void GetBalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Balance from UserTbl where AccNumb = '" + Acc + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblBalance.Text = "Rp " +dt.Rows[0][0].ToString();
            blc = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void btWithdraw_Click(object sender, EventArgs e)
        {
            if (tbWithdraw.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else if (Convert.ToInt32(tbWithdraw.Text) <= 0) 
            {
                MessageBox.Show("Enter a valid amount");
            }
            else if (Convert.ToInt32(tbWithdraw.Text) > blc)
            {
                MessageBox.Show("Balance not enough");

            }
            else
            {
                try
                {
                    newbalance = blc - Convert.ToInt32(tbWithdraw.Text);
                    try
                    {
                        Con.Open();
                        string query = "update UserTbl set Balance = " + newbalance + " where AccNumb='" + Acc + "' ";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Success Withdraw");
                        Con.Close();
                        Home home = new Home();
                        home.Show();
                        this.Hide();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
