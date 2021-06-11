
namespace ATMSystem
{
    partial class Login
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
            this.btLogIn = new System.Windows.Forms.Button();
            this.btRegist = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.tbAccNumb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "ATM";
            // 
            // btLogIn
            // 
            this.btLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btLogIn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btLogIn.Location = new System.Drawing.Point(279, 257);
            this.btLogIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogIn.Name = "btLogIn";
            this.btLogIn.Size = new System.Drawing.Size(100, 36);
            this.btLogIn.TabIndex = 14;
            this.btLogIn.Text = "Login";
            this.btLogIn.UseVisualStyleBackColor = true;
            this.btLogIn.Click += new System.EventHandler(this.btLogIn_Click);
            // 
            // btRegist
            // 
            this.btRegist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btRegist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btRegist.Location = new System.Drawing.Point(148, 257);
            this.btRegist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegist.Name = "btRegist";
            this.btRegist.Size = new System.Drawing.Size(100, 36);
            this.btRegist.TabIndex = 13;
            this.btRegist.Text = "Register";
            this.btRegist.UseVisualStyleBackColor = true;
            this.btRegist.Click += new System.EventHandler(this.btRegist_Click);
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPin.Location = new System.Drawing.Point(240, 185);
            this.tbPin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(172, 24);
            this.tbPin.TabIndex = 12;
            this.tbPin.UseSystemPasswordChar = true;
            // 
            // tbAccNumb
            // 
            this.tbAccNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbAccNumb.Location = new System.Drawing.Point(240, 144);
            this.tbAccNumb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAccNumb.Name = "tbAccNumb";
            this.tbAccNumb.Size = new System.Drawing.Size(172, 24);
            this.tbAccNumb.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(93, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "PIN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(93, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "ACC NUMBER :";
            // 
            // btExit
            // 
            this.btExit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btExit.Location = new System.Drawing.Point(457, 21);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(26, 25);
            this.btExit.TabIndex = 15;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(512, 352);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btLogIn);
            this.Controls.Add(this.btRegist);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.tbAccNumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLogIn;
        private System.Windows.Forms.Button btRegist;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.TextBox tbAccNumb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btExit;
    }
}