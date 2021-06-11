
namespace ATMSystem
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAccNumb = new System.Windows.Forms.TextBox();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
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
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(91, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACC NUMBER :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(91, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PIN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(91, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "NAME :";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbName.Location = new System.Drawing.Point(237, 117);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(172, 24);
            this.tbName.TabIndex = 4;
            // 
            // tbAccNumb
            // 
            this.tbAccNumb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbAccNumb.Location = new System.Drawing.Point(237, 160);
            this.tbAccNumb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAccNumb.Name = "tbAccNumb";
            this.tbAccNumb.Size = new System.Drawing.Size(172, 24);
            this.tbAccNumb.TabIndex = 5;
            // 
            // tbPin
            // 
            this.tbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbPin.Location = new System.Drawing.Point(237, 201);
            this.tbPin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(172, 24);
            this.tbPin.TabIndex = 6;
            this.tbPin.UseSystemPasswordChar = true;
            // 
            // btRegister
            // 
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btRegister.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btRegister.Location = new System.Drawing.Point(145, 258);
            this.btRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(100, 36);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btBack
            // 
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btBack.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btBack.Location = new System.Drawing.Point(276, 258);
            this.btBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(100, 36);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(512, 352);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.tbAccNumb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAccNumb;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbName;
    }
}