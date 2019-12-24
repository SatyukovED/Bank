namespace Bank
{
    partial class TransferMoneyForm
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
            this.components = new System.ComponentModel.Container();
            this.transferButton = new System.Windows.Forms.Button();
            this.receiverAccountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.receiverAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.transferSumTextBox = new System.Windows.Forms.TextBox();
            this.transferSumLabel = new System.Windows.Forms.Label();
            this.списокАктивныхВкладовКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1 = new Bank.BankDataSet();
            this.списокАктивныхКартКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокАктивныхКартКлиентаTableAdapter();
            this.списокАктивныхКартКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.списокАктивныхВкладовКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокАктивныхВкладовКлиентаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхВкладовКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхКартКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.transferButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.transferButton.ForeColor = System.Drawing.Color.Black;
            this.transferButton.Location = new System.Drawing.Point(216, 216);
            this.transferButton.Margin = new System.Windows.Forms.Padding(4);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(220, 80);
            this.transferButton.TabIndex = 79;
            this.transferButton.Text = "Перевести";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // receiverAccountNumberLabel
            // 
            this.receiverAccountNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.receiverAccountNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.receiverAccountNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.receiverAccountNumberLabel.Location = new System.Drawing.Point(8, 152);
            this.receiverAccountNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.receiverAccountNumberLabel.Name = "receiverAccountNumberLabel";
            this.receiverAccountNumberLabel.Size = new System.Drawing.Size(340, 40);
            this.receiverAccountNumberLabel.TabIndex = 78;
            this.receiverAccountNumberLabel.Text = "Номер счета получателя";
            this.receiverAccountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.accountNumberTextBox.Location = new System.Drawing.Point(368, 24);
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.ReadOnly = true;
            this.accountNumberTextBox.Size = new System.Drawing.Size(176, 42);
            this.accountNumberTextBox.TabIndex = 74;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.accountNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.accountNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.accountNumberLabel.Location = new System.Drawing.Point(72, 24);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(276, 40);
            this.accountNumberLabel.TabIndex = 73;
            this.accountNumberLabel.Text = "Номер кредита";
            this.accountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // receiverAccountNumberTextBox
            // 
            this.receiverAccountNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.receiverAccountNumberTextBox.Location = new System.Drawing.Point(368, 152);
            this.receiverAccountNumberTextBox.Name = "receiverAccountNumberTextBox";
            this.receiverAccountNumberTextBox.Size = new System.Drawing.Size(264, 42);
            this.receiverAccountNumberTextBox.TabIndex = 80;
            // 
            // transferSumTextBox
            // 
            this.transferSumTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.transferSumTextBox.Location = new System.Drawing.Point(368, 88);
            this.transferSumTextBox.Name = "transferSumTextBox";
            this.transferSumTextBox.Size = new System.Drawing.Size(264, 42);
            this.transferSumTextBox.TabIndex = 82;
            // 
            // transferSumLabel
            // 
            this.transferSumLabel.BackColor = System.Drawing.Color.MintCream;
            this.transferSumLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.transferSumLabel.ForeColor = System.Drawing.Color.Black;
            this.transferSumLabel.Location = new System.Drawing.Point(72, 88);
            this.transferSumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.transferSumLabel.Name = "transferSumLabel";
            this.transferSumLabel.Size = new System.Drawing.Size(276, 40);
            this.transferSumLabel.TabIndex = 81;
            this.transferSumLabel.Text = "Сумма";
            this.transferSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // списокАктивныхВкладовКлиентаBindingSource
            // 
            this.списокАктивныхВкладовКлиентаBindingSource.DataMember = "СписокАктивныхВкладовКлиента";
            this.списокАктивныхВкладовКлиентаBindingSource.DataSource = this.bankDataSet1;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "BankDataSet";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокАктивныхКартКлиентаTableAdapter
            // 
            this.списокАктивныхКартКлиентаTableAdapter.ClearBeforeFill = true;
            // 
            // списокАктивныхКартКлиентаBindingSource
            // 
            this.списокАктивныхКартКлиентаBindingSource.DataMember = "СписокАктивныхКартКлиента";
            this.списокАктивныхКартКлиентаBindingSource.DataSource = this.bankDataSet1;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокАктивныхВкладовКлиентаTableAdapter
            // 
            this.списокАктивныхВкладовКлиентаTableAdapter.ClearBeforeFill = true;
            // 
            // TransferMoneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(646, 311);
            this.Controls.Add(this.transferButton);
            this.Controls.Add(this.receiverAccountNumberLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.receiverAccountNumberTextBox);
            this.Controls.Add(this.transferSumTextBox);
            this.Controls.Add(this.transferSumLabel);
            this.Name = "TransferMoneyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевод";
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхВкладовКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхКартКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.Label receiverAccountNumberLabel;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.TextBox receiverAccountNumberTextBox;
        private System.Windows.Forms.BindingSource списокАктивныхВкладовКлиентаBindingSource;
        private BankDataSet bankDataSet1;
        private BankDataSetTableAdapters.СписокАктивныхКартКлиентаTableAdapter списокАктивныхКартКлиентаTableAdapter;
        private System.Windows.Forms.BindingSource списокАктивныхКартКлиентаBindingSource;
        private BankDataSet bankDataSet;
        private BankDataSetTableAdapters.СписокАктивныхВкладовКлиентаTableAdapter списокАктивныхВкладовКлиентаTableAdapter;
        private System.Windows.Forms.TextBox transferSumTextBox;
        private System.Windows.Forms.Label transferSumLabel;
    }
}