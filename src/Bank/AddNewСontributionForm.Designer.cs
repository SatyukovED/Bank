namespace Bank
{
    partial class AddNewContributionForm
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
            this.addNewContributionButton = new System.Windows.Forms.Button();
            this.newContributionDurationLabel = new System.Windows.Forms.Label();
            this.newContributionPercentLabel = new System.Windows.Forms.Label();
            this.addNewContributionFormLabel = new System.Windows.Forms.Label();
            this.newContributionPercentTextBox = new System.Windows.Forms.TextBox();
            this.newContributionDurationComboBox = new System.Windows.Forms.ComboBox();
            this.bankDataSet = new Bank.BankDataSet();
            this.получитьДанныеОтделенийОднойСтрокойBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьДанныеОтделенийОднойСтрокойTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewContributionButton
            // 
            this.addNewContributionButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewContributionButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.addNewContributionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewContributionButton.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, System.Drawing.FontStyle.Bold);
            this.addNewContributionButton.ForeColor = System.Drawing.Color.Black;
            this.addNewContributionButton.Location = new System.Drawing.Point(184, 280);
            this.addNewContributionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewContributionButton.Name = "addNewContributionButton";
            this.addNewContributionButton.Size = new System.Drawing.Size(220, 80);
            this.addNewContributionButton.TabIndex = 42;
            this.addNewContributionButton.Text = "Открыть";
            this.addNewContributionButton.UseVisualStyleBackColor = false;
            this.addNewContributionButton.Click += new System.EventHandler(this.addNewContributionButton_Click);
            // 
            // newContributionDurationLabel
            // 
            this.newContributionDurationLabel.BackColor = System.Drawing.Color.MintCream;
            this.newContributionDurationLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newContributionDurationLabel.ForeColor = System.Drawing.Color.Black;
            this.newContributionDurationLabel.Location = new System.Drawing.Point(32, 88);
            this.newContributionDurationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newContributionDurationLabel.Name = "newContributionDurationLabel";
            this.newContributionDurationLabel.Size = new System.Drawing.Size(248, 80);
            this.newContributionDurationLabel.TabIndex = 41;
            this.newContributionDurationLabel.Text = "Длительность";
            this.newContributionDurationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newContributionPercentLabel
            // 
            this.newContributionPercentLabel.BackColor = System.Drawing.Color.MintCream;
            this.newContributionPercentLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newContributionPercentLabel.ForeColor = System.Drawing.Color.Black;
            this.newContributionPercentLabel.Location = new System.Drawing.Point(32, 184);
            this.newContributionPercentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newContributionPercentLabel.Name = "newContributionPercentLabel";
            this.newContributionPercentLabel.Size = new System.Drawing.Size(248, 80);
            this.newContributionPercentLabel.TabIndex = 40;
            this.newContributionPercentLabel.Text = "Процент";
            this.newContributionPercentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewContributionFormLabel
            // 
            this.addNewContributionFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.addNewContributionFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNewContributionFormLabel.ForeColor = System.Drawing.Color.Black;
            this.addNewContributionFormLabel.Location = new System.Drawing.Point(0, 0);
            this.addNewContributionFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addNewContributionFormLabel.Name = "addNewContributionFormLabel";
            this.addNewContributionFormLabel.Size = new System.Drawing.Size(584, 80);
            this.addNewContributionFormLabel.TabIndex = 38;
            this.addNewContributionFormLabel.Text = "Введите данные нового вклада";
            this.addNewContributionFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newContributionPercentTextBox
            // 
            this.newContributionPercentTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.8F);
            this.newContributionPercentTextBox.Location = new System.Drawing.Point(312, 200);
            this.newContributionPercentTextBox.Name = "newContributionPercentTextBox";
            this.newContributionPercentTextBox.ReadOnly = true;
            this.newContributionPercentTextBox.Size = new System.Drawing.Size(176, 47);
            this.newContributionPercentTextBox.TabIndex = 45;
            // 
            // newContributionDurationComboBox
            // 
            this.newContributionDurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newContributionDurationComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newContributionDurationComboBox.FormattingEnabled = true;
            this.newContributionDurationComboBox.Items.AddRange(new object[] {
            "Бессрочно",
            "1 год",
            "5 лет",
            "10 лет"});
            this.newContributionDurationComboBox.Location = new System.Drawing.Point(312, 104);
            this.newContributionDurationComboBox.Name = "newContributionDurationComboBox";
            this.newContributionDurationComboBox.Size = new System.Drawing.Size(240, 46);
            this.newContributionDurationComboBox.TabIndex = 46;
            this.newContributionDurationComboBox.SelectedIndexChanged += new System.EventHandler(this.newContributionDurationComboBox_SelectedIndexChanged);
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
            // AddNewVkladForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(582, 380);
            this.Controls.Add(this.newContributionDurationComboBox);
            this.Controls.Add(this.addNewContributionButton);
            this.Controls.Add(this.newContributionDurationLabel);
            this.Controls.Add(this.newContributionPercentLabel);
            this.Controls.Add(this.addNewContributionFormLabel);
            this.Controls.Add(this.newContributionPercentTextBox);
            this.Name = "AddNewVkladForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Открыть новый вклад";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewContributionButton;
        private System.Windows.Forms.Label newContributionDurationLabel;
        private System.Windows.Forms.Label newContributionPercentLabel;
        private System.Windows.Forms.Label addNewContributionFormLabel;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource получитьДанныеОтделенийОднойСтрокойBindingSource;
        private BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter получитьДанныеОтделенийОднойСтрокойTableAdapter;
        private System.Windows.Forms.TextBox newContributionPercentTextBox;
        private System.Windows.Forms.ComboBox newContributionDurationComboBox;
    }
}