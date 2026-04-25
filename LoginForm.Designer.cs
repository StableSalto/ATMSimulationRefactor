namespace ATMSimulation
{
    partial class LoginForm
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
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_custNumber = new System.Windows.Forms.Label();
            this.lbl_custPin = new System.Windows.Forms.Label();
            this.txt_custNumber = new System.Windows.Forms.TextBox();
            this.txt_custPin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(181, 89);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbl_custNumber
            // 
            this.lbl_custNumber.AutoSize = true;
            this.lbl_custNumber.Location = new System.Drawing.Point(43, 30);
            this.lbl_custNumber.Name = "lbl_custNumber";
            this.lbl_custNumber.Size = new System.Drawing.Size(91, 13);
            this.lbl_custNumber.TabIndex = 1;
            this.lbl_custNumber.Text = "Customer Number";
            // 
            // lbl_custPin
            // 
            this.lbl_custPin.AutoSize = true;
            this.lbl_custPin.Location = new System.Drawing.Point(43, 61);
            this.lbl_custPin.Name = "lbl_custPin";
            this.lbl_custPin.Size = new System.Drawing.Size(22, 13);
            this.lbl_custPin.TabIndex = 2;
            this.lbl_custPin.Text = "Pin";
            // 
            // txt_custNumber
            // 
            this.txt_custNumber.Location = new System.Drawing.Point(156, 23);
            this.txt_custNumber.Name = "txt_custNumber";
            this.txt_custNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_custNumber.TabIndex = 3;
            // 
            // txt_custPin
            // 
            this.txt_custPin.Location = new System.Drawing.Point(156, 54);
            this.txt_custPin.Name = "txt_custPin";
            this.txt_custPin.Size = new System.Drawing.Size(100, 20);
            this.txt_custPin.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_custPin);
            this.Controls.Add(this.txt_custNumber);
            this.Controls.Add(this.lbl_custPin);
            this.Controls.Add(this.lbl_custNumber);
            this.Controls.Add(this.btn_login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_custNumber;
        private System.Windows.Forms.Label lbl_custPin;
        private System.Windows.Forms.TextBox txt_custNumber;
        private System.Windows.Forms.TextBox txt_custPin;
    }
}

