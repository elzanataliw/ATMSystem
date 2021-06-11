
namespace ATMSystem
{
    partial class Balance
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btQuit = new System.Windows.Forms.Button();
            this.lblAccNumb1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(96, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Your Balance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(96, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Acc Number :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "ATM";
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btQuit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btQuit.Location = new System.Drawing.Point(209, 270);
            this.btQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(100, 36);
            this.btQuit.TabIndex = 16;
            this.btQuit.Text = "Back";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // lblAccNumb1
            // 
            this.lblAccNumb1.AutoSize = true;
            this.lblAccNumb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblAccNumb1.Location = new System.Drawing.Point(259, 158);
            this.lblAccNumb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccNumb1.Name = "lblAccNumb1";
            this.lblAccNumb1.Size = new System.Drawing.Size(73, 18);
            this.lblAccNumb1.TabIndex = 17;
            this.lblAccNumb1.Text = "AccNumb";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBalance.Location = new System.Drawing.Point(259, 203);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(61, 18);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "Balance";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(512, 352);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAccNumb1);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Label lblAccNumb1;
        private System.Windows.Forms.Label lblBalance;
    }
}