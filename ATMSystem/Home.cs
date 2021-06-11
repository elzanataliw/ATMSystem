using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btDeposit_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void btWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Hide();
        }

        private void btBalance_Click(object sender, EventArgs e)
        {
            Balance blc = new Balance();
            this.Hide();
            blc.Show();
        }

        private void btChange_Click(object sender, EventArgs e)
        {
            ChangePin change = new ChangePin();
            change.Show();
            this.Hide();
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        public static string AccNumb;
        private void Home_Load(object sender, EventArgs e)
        {
            lblAccNumb.Text = "Account number : " + Login.AccNumb;
            AccNumb = Login.AccNumb;
        }
    }
}
