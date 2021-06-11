
namespace ATMSystem
{
    partial class Withdraw
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
            this.tbWithdraw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btWithdraw = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWithdraw
            // 
            this.tbWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbWithdraw.Location = new System.Drawing.Point(230, 152);
            this.tbWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.tbWithdraw.Name = "tbWithdraw";
            this.tbWithdraw.Size = new System.Drawing.Size(172, 24);
            this.tbWithdraw.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Insert Amount :";
            // 
            // btWithdraw
            // 
            this.btWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btWithdraw.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btWithdraw.Location = new System.Drawing.Point(209, 202);
            this.btWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btWithdraw.Name = "btWithdraw";
            this.btWithdraw.Size = new System.Drawing.Size(100, 36);
            this.btWithdraw.TabIndex = 23;
            this.btWithdraw.Text = "Withdraw";
            this.btWithdraw.UseVisualStyleBackColor = true;
            this.btWithdraw.Click += new System.EventHandler(this.btWithdraw_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btQuit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btQuit.Location = new System.Drawing.Point(209, 270);
            this.btQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(100, 36);
            this.btQuit.TabIndex = 25;
            this.btQuit.Text = "Back";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 54);
            this.label1.TabIndex = 21;
            this.label1.Text = "Withdraw";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(187, 107);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(120, 17);
            this.lblBalance.TabIndex = 26;
            this.lblBalance.Text = "Available Balance";
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(512, 352);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbWithdraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btWithdraw);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btWithdraw;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
    }
}