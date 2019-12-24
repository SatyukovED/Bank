namespace Bank
{
    partial class ChooseTransactionForm
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
            this.fillUpAccountButton = new System.Windows.Forms.Button();
            this.chooseTransactionFormLabel = new System.Windows.Forms.Label();
            this.transferMoneyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fillUpAccountButton
            // 
            this.fillUpAccountButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fillUpAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.fillUpAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillUpAccountButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.fillUpAccountButton.ForeColor = System.Drawing.Color.Black;
            this.fillUpAccountButton.Location = new System.Drawing.Point(112, 72);
            this.fillUpAccountButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillUpAccountButton.Name = "fillUpAccountButton";
            this.fillUpAccountButton.Size = new System.Drawing.Size(192, 64);
            this.fillUpAccountButton.TabIndex = 44;
            this.fillUpAccountButton.Text = "Пополнить";
            this.fillUpAccountButton.UseVisualStyleBackColor = false;
            this.fillUpAccountButton.Click += new System.EventHandler(this.fillUpAccountButton_Click);
            // 
            // chooseTransactionFormLabel
            // 
            this.chooseTransactionFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.chooseTransactionFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.chooseTransactionFormLabel.ForeColor = System.Drawing.Color.Black;
            this.chooseTransactionFormLabel.Location = new System.Drawing.Point(0, 0);
            this.chooseTransactionFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.chooseTransactionFormLabel.Name = "chooseTransactionFormLabel";
            this.chooseTransactionFormLabel.Size = new System.Drawing.Size(416, 56);
            this.chooseTransactionFormLabel.TabIndex = 43;
            this.chooseTransactionFormLabel.Text = "Выберите операцию";
            this.chooseTransactionFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferMoneyButton
            // 
            this.transferMoneyButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.transferMoneyButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.transferMoneyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferMoneyButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.transferMoneyButton.ForeColor = System.Drawing.Color.Black;
            this.transferMoneyButton.Location = new System.Drawing.Point(112, 160);
            this.transferMoneyButton.Margin = new System.Windows.Forms.Padding(4);
            this.transferMoneyButton.Name = "transferMoneyButton";
            this.transferMoneyButton.Size = new System.Drawing.Size(192, 64);
            this.transferMoneyButton.TabIndex = 45;
            this.transferMoneyButton.Text = "Перевести";
            this.transferMoneyButton.UseVisualStyleBackColor = false;
            this.transferMoneyButton.Click += new System.EventHandler(this.transferMoneyButton_Click);
            // 
            // ChooseTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(414, 256);
            this.Controls.Add(this.transferMoneyButton);
            this.Controls.Add(this.fillUpAccountButton);
            this.Controls.Add(this.chooseTransactionFormLabel);
            this.Name = "ChooseTransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Операции";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fillUpAccountButton;
        private System.Windows.Forms.Label chooseTransactionFormLabel;
        private System.Windows.Forms.Button transferMoneyButton;
    }
}