namespace Bank
{
    partial class CreditPaymentForm
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
            this.creditNumberTextBox = new System.Windows.Forms.TextBox();
            this.creditNumberLabel = new System.Windows.Forms.Label();
            this.fillUpTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fillUpTypeLabel = new System.Windows.Forms.Label();
            this.sumToPayLabel = new System.Windows.Forms.Label();
            this.sumToPayTextBox = new System.Windows.Forms.TextBox();
            this.restOfCreditSumTextBox = new System.Windows.Forms.TextBox();
            this.restOfCreditSumLabel = new System.Windows.Forms.Label();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberComboBox = new System.Windows.Forms.ComboBox();
            this.payButton = new System.Windows.Forms.Button();
            this.bankDataSet = new Bank.BankDataSet();
            this.bankDataSet1 = new Bank.BankDataSet();
            this.списокАктивныхКартКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокАктивныхКартКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокАктивныхКартКлиентаTableAdapter();
            this.списокАктивныхВкладовКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.списокАктивныхВкладовКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокАктивныхВкладовКлиентаTableAdapter();
            this.noAccountTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхКартКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхВкладовКлиентаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // creditNumberTextBox
            // 
            this.creditNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.creditNumberTextBox.Location = new System.Drawing.Point(304, 16);
            this.creditNumberTextBox.Name = "creditNumberTextBox";
            this.creditNumberTextBox.ReadOnly = true;
            this.creditNumberTextBox.Size = new System.Drawing.Size(176, 42);
            this.creditNumberTextBox.TabIndex = 46;
            // 
            // creditNumberLabel
            // 
            this.creditNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.creditNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.creditNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.creditNumberLabel.Location = new System.Drawing.Point(8, 16);
            this.creditNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.creditNumberLabel.Name = "creditNumberLabel";
            this.creditNumberLabel.Size = new System.Drawing.Size(276, 40);
            this.creditNumberLabel.TabIndex = 45;
            this.creditNumberLabel.Text = "Номер кредита";
            this.creditNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fillUpTypeComboBox
            // 
            this.fillUpTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.fillUpTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillUpTypeComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.2F);
            this.fillUpTypeComboBox.FormattingEnabled = true;
            this.fillUpTypeComboBox.ItemHeight = 33;
            this.fillUpTypeComboBox.Items.AddRange(new object[] {
            "Наличные",
            "Карта",
            "Вклад"});
            this.fillUpTypeComboBox.Location = new System.Drawing.Point(304, 184);
            this.fillUpTypeComboBox.Name = "fillUpTypeComboBox";
            this.fillUpTypeComboBox.Size = new System.Drawing.Size(264, 41);
            this.fillUpTypeComboBox.TabIndex = 47;
            this.fillUpTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fillUpTypeComboBox_SelectedIndexChanged);
            // 
            // fillUpTypeLabel
            // 
            this.fillUpTypeLabel.BackColor = System.Drawing.Color.MintCream;
            this.fillUpTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fillUpTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.fillUpTypeLabel.Location = new System.Drawing.Point(8, 184);
            this.fillUpTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fillUpTypeLabel.Name = "fillUpTypeLabel";
            this.fillUpTypeLabel.Size = new System.Drawing.Size(276, 40);
            this.fillUpTypeLabel.TabIndex = 48;
            this.fillUpTypeLabel.Text = "Способ оплаты";
            this.fillUpTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sumToPayLabel
            // 
            this.sumToPayLabel.BackColor = System.Drawing.Color.MintCream;
            this.sumToPayLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sumToPayLabel.ForeColor = System.Drawing.Color.Black;
            this.sumToPayLabel.Location = new System.Drawing.Point(8, 72);
            this.sumToPayLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sumToPayLabel.Name = "sumToPayLabel";
            this.sumToPayLabel.Size = new System.Drawing.Size(276, 40);
            this.sumToPayLabel.TabIndex = 49;
            this.sumToPayLabel.Text = "Сумма";
            this.sumToPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sumToPayTextBox
            // 
            this.sumToPayTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.sumToPayTextBox.Location = new System.Drawing.Point(304, 72);
            this.sumToPayTextBox.Name = "sumToPayTextBox";
            this.sumToPayTextBox.Size = new System.Drawing.Size(264, 42);
            this.sumToPayTextBox.TabIndex = 50;
            // 
            // restOfCreditSumTextBox
            // 
            this.restOfCreditSumTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.restOfCreditSumTextBox.Location = new System.Drawing.Point(304, 128);
            this.restOfCreditSumTextBox.Name = "restOfCreditSumTextBox";
            this.restOfCreditSumTextBox.ReadOnly = true;
            this.restOfCreditSumTextBox.Size = new System.Drawing.Size(264, 42);
            this.restOfCreditSumTextBox.TabIndex = 54;
            // 
            // restOfCreditSumLabel
            // 
            this.restOfCreditSumLabel.BackColor = System.Drawing.Color.MintCream;
            this.restOfCreditSumLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.restOfCreditSumLabel.ForeColor = System.Drawing.Color.Black;
            this.restOfCreditSumLabel.Location = new System.Drawing.Point(-16, 128);
            this.restOfCreditSumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.restOfCreditSumLabel.Name = "restOfCreditSumLabel";
            this.restOfCreditSumLabel.Size = new System.Drawing.Size(300, 40);
            this.restOfCreditSumLabel.TabIndex = 53;
            this.restOfCreditSumLabel.Text = "Остаток по кредиту";
            this.restOfCreditSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.accountNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.accountNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.accountNumberLabel.Location = new System.Drawing.Point(8, 240);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(276, 40);
            this.accountNumberLabel.TabIndex = 56;
            this.accountNumberLabel.Text = "Номер счета";
            this.accountNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountNumberLabel.Visible = false;
            // 
            // accountNumberComboBox
            // 
            this.accountNumberComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.accountNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountNumberComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.2F);
            this.accountNumberComboBox.FormattingEnabled = true;
            this.accountNumberComboBox.ItemHeight = 33;
            this.accountNumberComboBox.Location = new System.Drawing.Point(304, 240);
            this.accountNumberComboBox.Name = "accountNumberComboBox";
            this.accountNumberComboBox.Size = new System.Drawing.Size(264, 41);
            this.accountNumberComboBox.TabIndex = 55;
            this.accountNumberComboBox.Visible = false;
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.payButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.payButton.ForeColor = System.Drawing.Color.Black;
            this.payButton.Location = new System.Drawing.Point(192, 312);
            this.payButton.Margin = new System.Windows.Forms.Padding(4);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(220, 80);
            this.payButton.TabIndex = 57;
            this.payButton.Text = "Оплатить";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "BankDataSet";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокАктивныхКартКлиентаBindingSource
            // 
            this.списокАктивныхКартКлиентаBindingSource.DataMember = "СписокАктивныхКартКлиента";
            this.списокАктивныхКартКлиентаBindingSource.DataSource = this.bankDataSet1;
            // 
            // списокАктивныхКартКлиентаTableAdapter
            // 
            this.списокАктивныхКартКлиентаTableAdapter.ClearBeforeFill = true;
            // 
            // списокАктивныхВкладовКлиентаBindingSource
            // 
            this.списокАктивныхВкладовКлиентаBindingSource.DataMember = "СписокАктивныхВкладовКлиента";
            this.списокАктивныхВкладовКлиентаBindingSource.DataSource = this.bankDataSet1;
            // 
            // списокАктивныхВкладовКлиентаTableAdapter
            // 
            this.списокАктивныхВкладовКлиентаTableAdapter.ClearBeforeFill = true;
            // 
            // noAccountTextBox
            // 
            this.noAccountTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.noAccountTextBox.Location = new System.Drawing.Point(304, 240);
            this.noAccountTextBox.Name = "noAccountTextBox";
            this.noAccountTextBox.ReadOnly = true;
            this.noAccountTextBox.Size = new System.Drawing.Size(264, 42);
            this.noAccountTextBox.TabIndex = 58;
            this.noAccountTextBox.Visible = false;
            // 
            // CreditPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(596, 410);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.restOfCreditSumTextBox);
            this.Controls.Add(this.restOfCreditSumLabel);
            this.Controls.Add(this.sumToPayTextBox);
            this.Controls.Add(this.sumToPayLabel);
            this.Controls.Add(this.fillUpTypeLabel);
            this.Controls.Add(this.fillUpTypeComboBox);
            this.Controls.Add(this.creditNumberTextBox);
            this.Controls.Add(this.creditNumberLabel);
            this.Controls.Add(this.accountNumberComboBox);
            this.Controls.Add(this.noAccountTextBox);
            this.Name = "CreditPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оплата по кредиту";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхКартКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхВкладовКлиентаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox creditNumberTextBox;
        private System.Windows.Forms.Label creditNumberLabel;
        private System.Windows.Forms.ComboBox fillUpTypeComboBox;
        private System.Windows.Forms.Label fillUpTypeLabel;
        private System.Windows.Forms.Label sumToPayLabel;
        private System.Windows.Forms.TextBox sumToPayTextBox;
        private System.Windows.Forms.TextBox restOfCreditSumTextBox;
        private System.Windows.Forms.Label restOfCreditSumLabel;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.ComboBox accountNumberComboBox;
        private System.Windows.Forms.Button payButton;
        private BankDataSet bankDataSet;
        private BankDataSet bankDataSet1;
        private System.Windows.Forms.BindingSource списокАктивныхКартКлиентаBindingSource;
        private BankDataSetTableAdapters.СписокАктивныхКартКлиентаTableAdapter списокАктивныхКартКлиентаTableAdapter;
        private System.Windows.Forms.BindingSource списокАктивныхВкладовКлиентаBindingSource;
        private BankDataSetTableAdapters.СписокАктивныхВкладовКлиентаTableAdapter списокАктивныхВкладовКлиентаTableAdapter;
        private System.Windows.Forms.TextBox noAccountTextBox;
    }
}