namespace BankAccountWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonDeposit = new Button();
            buttonWithdraw = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonDeposit
            // 
            buttonDeposit.Location = new Point(12, 12);
            buttonDeposit.Name = "buttonDeposit";
            buttonDeposit.Size = new Size(94, 29);
            buttonDeposit.TabIndex = 0;
            buttonDeposit.Text = "Deposit";
            buttonDeposit.UseVisualStyleBackColor = true;
            buttonDeposit.Click += buttonDeposit_Click;
            // 
            // buttonWithdraw
            // 
            buttonWithdraw.Location = new Point(12, 47);
            buttonWithdraw.Name = "buttonWithdraw";
            buttonWithdraw.Size = new Size(94, 29);
            buttonWithdraw.TabIndex = 1;
            buttonWithdraw.Text = "Withdraw";
            buttonWithdraw.UseVisualStyleBackColor = true;
            buttonWithdraw.Click += buttonWithdraw_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(139, 28);
            label1.Name = "label1";
            label1.Size = new Size(194, 81);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 142);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonWithdraw);
            Controls.Add(buttonDeposit);
            Name = "Form1";
            Text = "BankAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeposit;
        private Button buttonWithdraw;
        private TextBox textBox1;
        private Label label1;
    }
}