
namespace ATMSystem
{
    partial class Deposit
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "Deposit";
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btQuit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btQuit.Location = new System.Drawing.Point(209, 270);
            this.btQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(100, 36);
            this.btQuit.TabIndex = 20;
            this.btQuit.Text = "Back";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // btDeposit
            // 
            this.btDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btDeposit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btDeposit.Location = new System.Drawing.Point(209, 202);
            this.btDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDeposit.Name = "btDeposit";
            this.btDeposit.Size = new System.Drawing.Size(100, 36);
            this.btDeposit.TabIndex = 18;
            this.btDeposit.Text = "Deposit";
            this.btDeposit.UseVisualStyleBackColor = true;
            this.btDeposit.Click += new System.EventHandler(this.btDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Insert Amount :";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbDeposit.Location = new System.Drawing.Point(231, 151);
            this.tbDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Size = new System.Drawing.Size(172, 24);
            this.tbDeposit.TabIndex = 17;
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(512, 352);
            this.Controls.Add(this.tbDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btDeposit);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Deposit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btQuit;
        private System.Windows.Forms.Button btDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDeposit;
    }
}