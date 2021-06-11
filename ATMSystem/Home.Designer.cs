
namespace ATMSystem
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.btQuit = new System.Windows.Forms.Button();
            this.btDeposit = new System.Windows.Forms.Button();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.btBalance = new System.Windows.Forms.Button();
            this.btChange = new System.Windows.Forms.Button();
            this.lblAccNumb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Main Menu";
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btQuit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btQuit.Location = new System.Drawing.Point(280, 361);
            this.btQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(100, 36);
            this.btQuit.TabIndex = 10;
            this.btQuit.Text = "Log out";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btDeposit
            // 
            this.btDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeposit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btDeposit.Location = new System.Drawing.Point(71, 172);
            this.btDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(237, 49);
            this.btDeposit.TabIndex = 6;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = true;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // btWithdraw
            // 
            this.btWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btWithdraw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btWithdraw.Location = new System.Drawing.Point(71, 255);
            this.btWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(237, 49);
            this.btWithdraw.TabIndex = 7;
            this.btWithdraw.Text = "Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = true;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // btBalance
            // 
            this.btBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBalance.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btBalance.Location = new System.Drawing.Point(351, 172);
            this.btBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBalance.Name = "btBalance";
            this.btBalance.Size = new System.Drawing.Size(237, 49);
            this.btBalance.TabIndex = 8;
            this.btBalance.Text = "Balance Inquiry";
            this.btBalance.UseVisualStyleBackColor = true;
            this.btBalance.Click += new System.EventHandler(this.btBalance_Click);
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btChange.Location = new System.Drawing.Point(351, 255);
            this.btChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(237, 49);
            this.btChange.TabIndex = 9;
            this.btChange.Text = "Change Pin";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // lblAccNumb
            // 
            this.lblAccNumb.AutoSize = true;
            this.lblAccNumb.Location = new System.Drawing.Point(256, 127);
            this.lblAccNumb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNumb.Name = "lblAccNumb";
            this.lblAccNumb.Size = new System.Drawing.Size(121, 17);
            this.lblAccNumb.TabIndex = 11;
            this.lblAccNumb.Text = "Account Number :";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(660, 434);
            this.Controls.Add(this.lblAccNumb);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btBalance);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.btDeposit);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Button btBalance;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Label lblAccNumb;
    }
}