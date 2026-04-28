namespace ATMSimulation
{
    partial class MainForm
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
            this.lblAccountNumberDisplay = new System.Windows.Forms.Label();
            this.lblSavingsAccount = new System.Windows.Forms.Label();
            this.lblCheckingAccount = new System.Windows.Forms.Label();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.ButtonDeposit = new System.Windows.Forms.Button();
            this.ButtonWithdraw = new System.Windows.Forms.Button();
            this.rbtnSavings = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.lblAmount = new System.Windows.Forms.Label();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAccountNumberDisplay
            // 
            this.lblAccountNumberDisplay.AutoSize = true;
            this.lblAccountNumberDisplay.Location = new System.Drawing.Point(13, 38);
            this.lblAccountNumberDisplay.Name = "lblAccountNumberDisplay";
            this.lblAccountNumberDisplay.Size = new System.Drawing.Size(129, 13);
            this.lblAccountNumberDisplay.TabIndex = 0;
            this.lblAccountNumberDisplay.Text = "Welcome Account Holder";
            // 
            // lblSavingsAccount
            // 
            this.lblSavingsAccount.AutoSize = true;
            this.lblSavingsAccount.Location = new System.Drawing.Point(13, 126);
            this.lblSavingsAccount.Name = "lblSavingsAccount";
            this.lblSavingsAccount.Size = new System.Drawing.Size(144, 13);
            this.lblSavingsAccount.TabIndex = 1;
            this.lblSavingsAccount.Text = "Balance in Savings Account:";
            // 
            // lblCheckingAccount
            // 
            this.lblCheckingAccount.AutoSize = true;
            this.lblCheckingAccount.Location = new System.Drawing.Point(13, 164);
            this.lblCheckingAccount.Name = "lblCheckingAccount";
            this.lblCheckingAccount.Size = new System.Drawing.Size(151, 13);
            this.lblCheckingAccount.TabIndex = 2;
            this.lblCheckingAccount.Text = "Balance in Checking Account:";
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.Location = new System.Drawing.Point(164, 126);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(84, 13);
            this.lblSavingsBalance.TabIndex = 3;
            this.lblSavingsBalance.Text = "savings balance";
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.Location = new System.Drawing.Point(167, 164);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(92, 13);
            this.lblCheckingBalance.TabIndex = 4;
            this.lblCheckingBalance.Text = "checking balance";
            // 
            // ButtonDeposit
            // 
            this.ButtonDeposit.Enabled = false;
            this.ButtonDeposit.Location = new System.Drawing.Point(578, 145);
            this.ButtonDeposit.Name = "ButtonDeposit";
            this.ButtonDeposit.Size = new System.Drawing.Size(75, 23);
            this.ButtonDeposit.TabIndex = 5;
            this.ButtonDeposit.Text = "Deposit";
            this.ButtonDeposit.UseVisualStyleBackColor = true;
            this.ButtonDeposit.Click += new System.EventHandler(this.ButtonDeposit_Click);
            // 
            // ButtonWithdraw
            // 
            this.ButtonWithdraw.Enabled = false;
            this.ButtonWithdraw.Location = new System.Drawing.Point(659, 145);
            this.ButtonWithdraw.Name = "ButtonWithdraw";
            this.ButtonWithdraw.Size = new System.Drawing.Size(75, 23);
            this.ButtonWithdraw.TabIndex = 6;
            this.ButtonWithdraw.Text = "Withdraw";
            this.ButtonWithdraw.UseVisualStyleBackColor = true;
            this.ButtonWithdraw.Click += new System.EventHandler(this.ButtonWithdraw_Click);
            // 
            // rbtnSavings
            // 
            this.rbtnSavings.AutoSize = true;
            this.rbtnSavings.Location = new System.Drawing.Point(621, 65);
            this.rbtnSavings.Name = "rbtnSavings";
            this.rbtnSavings.Size = new System.Drawing.Size(106, 17);
            this.rbtnSavings.TabIndex = 7;
            this.rbtnSavings.TabStop = true;
            this.rbtnSavings.Text = "Savings Account";
            this.rbtnSavings.UseVisualStyleBackColor = true;
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.Location = new System.Drawing.Point(621, 89);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(113, 17);
            this.rbtnChecking.TabIndex = 8;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking Account";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(470, 126);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(150, 13);
            this.lblAmount.TabIndex = 9;
            this.lblAmount.Text = "Amount to Deposit/Withdraw: ";
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Location = new System.Drawing.Point(621, 119);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.TextBoxAmount.TabIndex = 10;
            this.TextBoxAmount.TextChanged += new System.EventHandler(this.TextBoxAmount_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.rbtnChecking);
            this.Controls.Add(this.rbtnSavings);
            this.Controls.Add(this.ButtonWithdraw);
            this.Controls.Add(this.ButtonDeposit);
            this.Controls.Add(this.lblCheckingBalance);
            this.Controls.Add(this.lblSavingsBalance);
            this.Controls.Add(this.lblCheckingAccount);
            this.Controls.Add(this.lblSavingsAccount);
            this.Controls.Add(this.lblAccountNumberDisplay);
            this.Name = "MainForm";
            this.Text = "Automatic Teller Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccountNumberDisplay;
        private System.Windows.Forms.Label lblSavingsAccount;
        private System.Windows.Forms.Label lblCheckingAccount;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Button ButtonDeposit;
        private System.Windows.Forms.Button ButtonWithdraw;
        private System.Windows.Forms.RadioButton rbtnSavings;
        private System.Windows.Forms.RadioButton rbtnChecking;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox TextBoxAmount;
    }
}
