namespace Bank
{
    partial class AddNewCreditRequestForm
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
            this.newRequestSumComboBox = new System.Windows.Forms.ComboBox();
            this.addNewCreditRequestButton = new System.Windows.Forms.Button();
            this.newRequestDurationLabel = new System.Windows.Forms.Label();
            this.newRequestPercentLabel = new System.Windows.Forms.Label();
            this.addNewCreditRequestFormLabel = new System.Windows.Forms.Label();
            this.newRequestPercentTextBox = new System.Windows.Forms.TextBox();
            this.bankDataSet = new Bank.BankDataSet();
            this.получитьДанныеОтделенийОднойСтрокойBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьДанныеОтделенийОднойСтрокойTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter();
            this.newRequestSumLabel = new System.Windows.Forms.Label();
            this.newRequestDurationComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // newRequestSumComboBox
            // 
            this.newRequestSumComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRequestSumComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRequestSumComboBox.FormattingEnabled = true;
            this.newRequestSumComboBox.Items.AddRange(new object[] {
            "100000",
            "250000",
            "500000",
            "1000000"});
            this.newRequestSumComboBox.Location = new System.Drawing.Point(304, 96);
            this.newRequestSumComboBox.Name = "newRequestSumComboBox";
            this.newRequestSumComboBox.Size = new System.Drawing.Size(240, 46);
            this.newRequestSumComboBox.TabIndex = 52;
            this.newRequestSumComboBox.SelectedIndexChanged += new System.EventHandler(this.newRequestSumComboBox_SelectedIndexChanged);
            // 
            // addNewCreditRequestButton
            // 
            this.addNewCreditRequestButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewCreditRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.addNewCreditRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewCreditRequestButton.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, System.Drawing.FontStyle.Bold);
            this.addNewCreditRequestButton.ForeColor = System.Drawing.Color.Black;
            this.addNewCreditRequestButton.Location = new System.Drawing.Point(184, 344);
            this.addNewCreditRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewCreditRequestButton.Name = "addNewCreditRequestButton";
            this.addNewCreditRequestButton.Size = new System.Drawing.Size(220, 80);
            this.addNewCreditRequestButton.TabIndex = 50;
            this.addNewCreditRequestButton.Text = "Отправить";
            this.addNewCreditRequestButton.UseVisualStyleBackColor = false;
            this.addNewCreditRequestButton.Click += new System.EventHandler(this.addNewCreditRequestButton_Click);
            // 
            // newRequestDurationLabel
            // 
            this.newRequestDurationLabel.BackColor = System.Drawing.Color.MintCream;
            this.newRequestDurationLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRequestDurationLabel.ForeColor = System.Drawing.Color.Black;
            this.newRequestDurationLabel.Location = new System.Drawing.Point(32, 168);
            this.newRequestDurationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newRequestDurationLabel.Name = "newRequestDurationLabel";
            this.newRequestDurationLabel.Size = new System.Drawing.Size(248, 80);
            this.newRequestDurationLabel.TabIndex = 49;
            this.newRequestDurationLabel.Text = "Длительность";
            this.newRequestDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRequestPercentLabel
            // 
            this.newRequestPercentLabel.BackColor = System.Drawing.Color.MintCream;
            this.newRequestPercentLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRequestPercentLabel.ForeColor = System.Drawing.Color.Black;
            this.newRequestPercentLabel.Location = new System.Drawing.Point(32, 256);
            this.newRequestPercentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newRequestPercentLabel.Name = "newRequestPercentLabel";
            this.newRequestPercentLabel.Size = new System.Drawing.Size(248, 80);
            this.newRequestPercentLabel.TabIndex = 48;
            this.newRequestPercentLabel.Text = "Процент";
            this.newRequestPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewCreditRequestFormLabel
            // 
            this.addNewCreditRequestFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.addNewCreditRequestFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNewCreditRequestFormLabel.ForeColor = System.Drawing.Color.Black;
            this.addNewCreditRequestFormLabel.Location = new System.Drawing.Point(0, 0);
            this.addNewCreditRequestFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addNewCreditRequestFormLabel.Name = "addNewCreditRequestFormLabel";
            this.addNewCreditRequestFormLabel.Size = new System.Drawing.Size(584, 80);
            this.addNewCreditRequestFormLabel.TabIndex = 47;
            this.addNewCreditRequestFormLabel.Text = "Введите данные заявки на кредит";
            this.addNewCreditRequestFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRequestPercentTextBox
            // 
            this.newRequestPercentTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.8F);
            this.newRequestPercentTextBox.Location = new System.Drawing.Point(304, 272);
            this.newRequestPercentTextBox.Name = "newRequestPercentTextBox";
            this.newRequestPercentTextBox.ReadOnly = true;
            this.newRequestPercentTextBox.Size = new System.Drawing.Size(176, 47);
            this.newRequestPercentTextBox.TabIndex = 51;
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
            // newRequestSumLabel
            // 
            this.newRequestSumLabel.BackColor = System.Drawing.Color.MintCream;
            this.newRequestSumLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRequestSumLabel.ForeColor = System.Drawing.Color.Black;
            this.newRequestSumLabel.Location = new System.Drawing.Point(32, 80);
            this.newRequestSumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newRequestSumLabel.Name = "newRequestSumLabel";
            this.newRequestSumLabel.Size = new System.Drawing.Size(248, 80);
            this.newRequestSumLabel.TabIndex = 53;
            this.newRequestSumLabel.Text = "Сумма";
            this.newRequestSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newRequestDurationComboBox
            // 
            this.newRequestDurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newRequestDurationComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newRequestDurationComboBox.FormattingEnabled = true;
            this.newRequestDurationComboBox.Items.AddRange(new object[] {
            "1 год",
            "2,5 года",
            "5 лет",
            "10 лет"});
            this.newRequestDurationComboBox.Location = new System.Drawing.Point(304, 184);
            this.newRequestDurationComboBox.Name = "newRequestDurationComboBox";
            this.newRequestDurationComboBox.Size = new System.Drawing.Size(240, 46);
            this.newRequestDurationComboBox.TabIndex = 54;
            // 
            // AddNewCreditRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(582, 442);
            this.Controls.Add(this.newRequestDurationComboBox);
            this.Controls.Add(this.newRequestSumLabel);
            this.Controls.Add(this.newRequestSumComboBox);
            this.Controls.Add(this.addNewCreditRequestButton);
            this.Controls.Add(this.newRequestDurationLabel);
            this.Controls.Add(this.newRequestPercentLabel);
            this.Controls.Add(this.addNewCreditRequestFormLabel);
            this.Controls.Add(this.newRequestPercentTextBox);
            this.Name = "AddNewCreditRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подать заявку на кредит";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox newRequestSumComboBox;
        private System.Windows.Forms.Button addNewCreditRequestButton;
        private System.Windows.Forms.Label newRequestDurationLabel;
        private System.Windows.Forms.Label newRequestPercentLabel;
        private System.Windows.Forms.Label addNewCreditRequestFormLabel;
        private System.Windows.Forms.TextBox newRequestPercentTextBox;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource получитьДанныеОтделенийОднойСтрокойBindingSource;
        private BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter получитьДанныеОтделенийОднойСтрокойTableAdapter;
        private System.Windows.Forms.Label newRequestSumLabel;
        private System.Windows.Forms.ComboBox newRequestDurationComboBox;
    }
}