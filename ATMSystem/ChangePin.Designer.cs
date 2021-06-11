
namespace ATMSystem
{
    partial class ChangePin
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
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.tbNewpin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.btQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "ATM";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbConfirm.Location = new System.Drawing.Point(243, 183);
            this.tbConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(172, 24);
            this.tbConfirm.TabIndex = 20;
            this.tbConfirm.UseSystemPasswordChar = true;
            // 
            // tbNewpin
            // 
            this.tbNewpin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbNewpin.Location = new System.Drawing.Point(243, 143);
            this.tbNewpin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewpin.Name = "tbNewpin";
            this.tbNewpin.Size = new System.Drawing.Size(172, 24);
            this.tbNewpin.TabIndex = 19;
            this.tbNewpin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(96, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Confirm Pin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(96, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "New Pin :";
            // 
            // btChange
            // 
            this.btChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btChange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btChange.Location = new System.Drawing.Point(143, 254);
            this.btChange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(100, 36);
            this.btChange.TabIndex = 21;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btQuit
            // 
            this.btQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btQuit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btQuit.Location = new System.Drawing.Point(277, 254);
            this.btQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btQuit.Name = "btQuit";
            this.btQuit.Size = new System.Drawing.Size(100, 36);
            this.btQuit.TabIndex = 22;
            this.btQuit.Text = "Back";
            this.btQuit.UseVisualStyleBackColor = true;
            this.btQuit.Click += new System.EventHandler(this.btQuit_Click);
            // 
            // ChangePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(512, 352);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.btQuit);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.tbNewpin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangePin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.TextBox tbNewpin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btQuit;
    }
}