namespace Bank
{
    partial class AddNewClientFrom
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
            this.newClientNameTextBox = new System.Windows.Forms.TextBox();
            this.addNewClientButton = new System.Windows.Forms.Button();
            this.newClientIncomeLabel = new System.Windows.Forms.Label();
            this.newClientTownLabel = new System.Windows.Forms.Label();
            this.newClientNameLabel = new System.Windows.Forms.Label();
            this.newClientFormLabel = new System.Windows.Forms.Label();
            this.bankDataSet = new Bank.BankDataSet();
            this.получитьДанныеОтделенийОднойСтрокойBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьДанныеОтделенийОднойСтрокойTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter();
            this.newClientTownTextBox = new System.Windows.Forms.TextBox();
            this.newClientIncomeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newClientNameTextBox
            // 
            this.newClientNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.8F);
            this.newClientNameTextBox.Location = new System.Drawing.Point(292, 113);
            this.newClientNameTextBox.Name = "newClientNameTextBox";
            this.newClientNameTextBox.Size = new System.Drawing.Size(448, 47);
            this.newClientNameTextBox.TabIndex = 33;
            // 
            // addNewClientButton
            // 
            this.addNewClientButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewClientButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.addNewClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewClientButton.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, System.Drawing.FontStyle.Bold);
            this.addNewClientButton.ForeColor = System.Drawing.Color.Black;
            this.addNewClientButton.Location = new System.Drawing.Point(284, 357);
            this.addNewClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewClientButton.Name = "addNewClientButton";
            this.addNewClientButton.Size = new System.Drawing.Size(224, 80);
            this.addNewClientButton.TabIndex = 32;
            this.addNewClientButton.Text = "Добавить";
            this.addNewClientButton.UseVisualStyleBackColor = false;
            this.addNewClientButton.Click += new System.EventHandler(this.addNewClientButton_Click);
            // 
            // newClientIncomeLabel
            // 
            this.newClientIncomeLabel.BackColor = System.Drawing.Color.MintCream;
            this.newClientIncomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClientIncomeLabel.ForeColor = System.Drawing.Color.Black;
            this.newClientIncomeLabel.Location = new System.Drawing.Point(52, 253);
            this.newClientIncomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newClientIncomeLabel.Name = "newClientIncomeLabel";
            this.newClientIncomeLabel.Size = new System.Drawing.Size(216, 80);
            this.newClientIncomeLabel.TabIndex = 31;
            this.newClientIncomeLabel.Text = "Доход";
            this.newClientIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newClientTownLabel
            // 
            this.newClientTownLabel.BackColor = System.Drawing.Color.MintCream;
            this.newClientTownLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClientTownLabel.ForeColor = System.Drawing.Color.Black;
            this.newClientTownLabel.Location = new System.Drawing.Point(52, 173);
            this.newClientTownLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newClientTownLabel.Name = "newClientTownLabel";
            this.newClientTownLabel.Size = new System.Drawing.Size(216, 80);
            this.newClientTownLabel.TabIndex = 30;
            this.newClientTownLabel.Text = "Город";
            this.newClientTownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newClientNameLabel
            // 
            this.newClientNameLabel.BackColor = System.Drawing.Color.MintCream;
            this.newClientNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClientNameLabel.ForeColor = System.Drawing.Color.Black;
            this.newClientNameLabel.Location = new System.Drawing.Point(52, 93);
            this.newClientNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newClientNameLabel.Name = "newClientNameLabel";
            this.newClientNameLabel.Size = new System.Drawing.Size(216, 80);
            this.newClientNameLabel.TabIndex = 29;
            this.newClientNameLabel.Text = "ФИО";
            this.newClientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newClientFormLabel
            // 
            this.newClientFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.newClientFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.newClientFormLabel.ForeColor = System.Drawing.Color.Black;
            this.newClientFormLabel.Location = new System.Drawing.Point(36, 13);
            this.newClientFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newClientFormLabel.Name = "newClientFormLabel";
            this.newClientFormLabel.Size = new System.Drawing.Size(728, 80);
            this.newClientFormLabel.TabIndex = 28;
            this.newClientFormLabel.Text = "Введите данные нового клиента";
            this.newClientFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // получитьДанныеОтделенийОднойСтрокойBindingSource
            // 
            this.получитьДанныеОтделенийОднойСтрокойBindingSource.DataMember = "ПолучитьДанныеОтделенийОднойСтрокой";
            this.получитьДанныеОтделенийОднойСтрокойBindingSource.DataSource = this.bankDataSet;
            // 
            // получитьДанныеОтделенийОднойСтрокойTableAdapter
            // 
            this.получитьДанныеОтделенийОднойСтрокойTableAdapter.ClearBeforeFill = true;
            // 
            // newClientTownTextBox
            // 
            this.newClientTownTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.8F);
            this.newClientTownTextBox.Location = new System.Drawing.Point(292, 192);
            this.newClientTownTextBox.Name = "newClientTownTextBox";
            this.newClientTownTextBox.Size = new System.Drawing.Size(448, 47);
            this.newClientTownTextBox.TabIndex = 36;
            // 
            // newClientIncomeTextBox
            // 
            this.newClientIncomeTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.8F);
            this.newClientIncomeTextBox.Location = new System.Drawing.Point(292, 272);
            this.newClientIncomeTextBox.Name = "newClientIncomeTextBox";
            this.newClientIncomeTextBox.Size = new System.Drawing.Size(216, 47);
            this.newClientIncomeTextBox.TabIndex = 37;
            // 
            // AddNewClientFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newClientNameTextBox);
            this.Controls.Add(this.addNewClientButton);
            this.Controls.Add(this.newClientIncomeLabel);
            this.Controls.Add(this.newClientTownLabel);
            this.Controls.Add(this.newClientNameLabel);
            this.Controls.Add(this.newClientFormLabel);
            this.Controls.Add(this.newClientIncomeTextBox);
            this.Controls.Add(this.newClientTownTextBox);
            this.Name = "AddNewClientFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить нового клиента";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox newClientNameTextBox;
        private System.Windows.Forms.Button addNewClientButton;
        private System.Windows.Forms.Label newClientIncomeLabel;
        private System.Windows.Forms.Label newClientTownLabel;
        private System.Windows.Forms.Label newClientNameLabel;
        private System.Windows.Forms.Label newClientFormLabel;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource получитьДанныеОтделенийОднойСтрокойBindingSource;
        private BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter получитьДанныеОтделенийОднойСтрокойTableAdapter;
        private System.Windows.Forms.TextBox newClientTownTextBox;
        private System.Windows.Forms.TextBox newClientIncomeTextBox;
    }
}