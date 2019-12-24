namespace Bank
{
    partial class FillUpAccountForm
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
            this.noAccountTextBox = new System.Windows.Forms.TextBox();
            this.fillUpButton = new System.Windows.Forms.Button();
            this.accountNumberLabel = new System.Windows.Forms.Label();
            this.accountNumberComboBox = new System.Windows.Forms.ComboBox();
            this.fillUpTypeLabel = new System.Windows.Forms.Label();
            this.fillUpTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountToFillUpNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountToFillUpNumberLabel = new System.Windows.Forms.Label();
            this.списокАктивныхВкладовКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1 = new Bank.BankDataSet();
            this.списокАктивныхКартКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокАктивныхКартКлиентаTableAdapter();
            this.списокАктивныхКартКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.списокАктивныхВкладовКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокАктивныхВкладовКлиентаTableAdapter();
            this.sumToFillUpTextBox = new System.Windows.Forms.TextBox();
            this.sumToFillUpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхВкладовКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхКартКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // noAccountTextBox
            // 
            this.noAccountTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.noAccountTextBox.Location = new System.Drawing.Point(312, 184);
            this.noAccountTextBox.Name = "noAccountTextBox";
            this.noAccountTextBox.ReadOnly = true;
            this.noAccountTextBox.Size = new System.Drawing.Size(264, 42);
            this.noAccountTextBox.TabIndex = 70;
            this.noAccountTextBox.Visible = false;
            // 
            // fillUpButton
            // 
            this.fillUpButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fillUpButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.fillUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillUpButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.fillUpButton.ForeColor = System.Drawing.Color.Black;
            this.fillUpButton.Location = new System.Drawing.Point(184, 240);
            this.fillUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillUpButton.Name = "fillUpButton";
            this.fillUpButton.Size = new System.Drawing.Size(220, 80);
            this.fillUpButton.TabIndex = 69;
            this.fillUpButton.Text = "Пополнить";
            this.fillUpButton.UseVisualStyleBackColor = false;
            this.fillUpButton.Click += new System.EventHandler(this.fillUpButton_Click);
            // 
            // accountNumberLabel
            // 
            this.accountNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.accountNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.accountNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.accountNumberLabel.Location = new System.Drawing.Point(16, 184);
            this.accountNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountNumberLabel.Name = "accountNumberLabel";
            this.accountNumberLabel.Size = new System.Drawing.Size(276, 40);
            this.accountNumberLabel.TabIndex = 68;
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
            this.accountNumberComboBox.Location = new System.Drawing.Point(312, 184);
            this.accountNumberComboBox.Name = "accountNumberComboBox";
            this.accountNumberComboBox.Size = new System.Drawing.Size(264, 41);
            this.accountNumberComboBox.TabIndex = 67;
            this.accountNumberComboBox.Visible = false;
            // 
            // fillUpTypeLabel
            // 
            this.fillUpTypeLabel.BackColor = System.Drawing.Color.MintCream;
            this.fillUpTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.fillUpTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.fillUpTypeLabel.Location = new System.Drawing.Point(16, 128);
            this.fillUpTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fillUpTypeLabel.Name = "fillUpTypeLabel";
            this.fillUpTypeLabel.Size = new System.Drawing.Size(276, 40);
            this.fillUpTypeLabel.TabIndex = 62;
            this.fillUpTypeLabel.Text = "Способ пополнения";
            this.fillUpTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            "С карты",
            "С вклада"});
            this.fillUpTypeComboBox.Location = new System.Drawing.Point(312, 128);
            this.fillUpTypeComboBox.Name = "fillUpTypeComboBox";
            this.fillUpTypeComboBox.Size = new System.Drawing.Size(264, 41);
            this.fillUpTypeComboBox.TabIndex = 61;
            this.fillUpTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fillUpTypeComboBox_SelectedIndexChanged);
            // 
            // accountToFillUpNumberTextBox
            // 
            this.accountToFillUpNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.accountToFillUpNumberTextBox.Location = new System.Drawing.Point(312, 16);
            this.accountToFillUpNumberTextBox.Name = "accountToFillUpNumberTextBox";
            this.accountToFillUpNumberTextBox.ReadOnly = true;
            this.accountToFillUpNumberTextBox.Size = new System.Drawing.Size(176, 42);
            this.accountToFillUpNumberTextBox.TabIndex = 60;
            // 
            // accountToFillUpNumberLabel
            // 
            this.accountToFillUpNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.accountToFillUpNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.accountToFillUpNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.accountToFillUpNumberLabel.Location = new System.Drawing.Point(13, 14);
            this.accountToFillUpNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.accountToFillUpNumberLabel.Name = "accountToFillUpNumberLabel";
            this.accountToFillUpNumberLabel.Size = new System.Drawing.Size(276, 40);
            this.accountToFillUpNumberLabel.TabIndex = 59;
            this.accountToFillUpNumberLabel.Text = "Номер кредита";
            this.accountToFillUpNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // sumToFillUpTextBox
            // 
            this.sumToFillUpTextBox.Font = new System.Drawing.Font("Comic Sans MS", 14.8F);
            this.sumToFillUpTextBox.Location = new System.Drawing.Point(312, 72);
            this.sumToFillUpTextBox.Name = "sumToFillUpTextBox";
            this.sumToFillUpTextBox.Size = new System.Drawing.Size(264, 42);
            this.sumToFillUpTextBox.TabIndex = 72;
            // 
            // sumToFillUpLabel
            // 
            this.sumToFillUpLabel.BackColor = System.Drawing.Color.MintCream;
            this.sumToFillUpLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.sumToFillUpLabel.ForeColor = System.Drawing.Color.Black;
            this.sumToFillUpLabel.Location = new System.Drawing.Point(16, 72);
            this.sumToFillUpLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sumToFillUpLabel.Name = "sumToFillUpLabel";
            this.sumToFillUpLabel.Size = new System.Drawing.Size(276, 40);
            this.sumToFillUpLabel.TabIndex = 71;
            this.sumToFillUpLabel.Text = "Сумма";
            this.sumToFillUpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FillUpAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(597, 333);
            this.Controls.Add(this.sumToFillUpTextBox);
            this.Controls.Add(this.sumToFillUpLabel);
            this.Controls.Add(this.fillUpButton);
            this.Controls.Add(this.accountNumberLabel);
            this.Controls.Add(this.fillUpTypeLabel);
            this.Controls.Add(this.fillUpTypeComboBox);
            this.Controls.Add(this.accountToFillUpNumberTextBox);
            this.Controls.Add(this.accountToFillUpNumberLabel);
            this.Controls.Add(this.noAccountTextBox);
            this.Controls.Add(this.accountNumberComboBox);
            this.Name = "FillUpAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пополнение счета";
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхВкладовКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокАктивныхКартКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox noAccountTextBox;
        private System.Windows.Forms.BindingSource списокАктивныхВкладовКлиентаBindingSource;
        private BankDataSet bankDataSet1;
        private BankDataSetTableAdapters.СписокАктивныхКартКлиентаTableAdapter списокАктивныхКартКлиентаTableAdapter;
        private System.Windows.Forms.BindingSource списокАктивныхКартКлиентаBindingSource;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.Button fillUpButton;
        private BankDataSetTableAdapters.СписокАктивныхВкладовКлиентаTableAdapter списокАктивныхВкладовКлиентаTableAdapter;
        private System.Windows.Forms.Label accountNumberLabel;
        private System.Windows.Forms.ComboBox accountNumberComboBox;
        private System.Windows.Forms.Label fillUpTypeLabel;
        private System.Windows.Forms.ComboBox fillUpTypeComboBox;
        private System.Windows.Forms.TextBox accountToFillUpNumberTextBox;
        private System.Windows.Forms.Label accountToFillUpNumberLabel;
        private System.Windows.Forms.TextBox sumToFillUpTextBox;
        private System.Windows.Forms.Label sumToFillUpLabel;
    }
}