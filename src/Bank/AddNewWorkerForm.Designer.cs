namespace Bank
{
    partial class addNewWorkerForm
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
            this.addNewWorkerFormLabel = new System.Windows.Forms.Label();
            this.newWorkerNameLabel = new System.Windows.Forms.Label();
            this.newWorkerDepartmentLabel = new System.Windows.Forms.Label();
            this.newWorkerPositionLabel = new System.Windows.Forms.Label();
            this.addNewWorkerButton = new System.Windows.Forms.Button();
            this.newWorkerNameTextBox = new System.Windows.Forms.TextBox();
            this.newWorkerDepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.bankDataSet = new Bank.BankDataSet();
            this.newWorkerPositionComboBox = new System.Windows.Forms.ComboBox();
            this.получитьДанныеОтделенийОднойСтрокойBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьДанныеОтделенийОднойСтрокойTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addNewWorkerFormLabel
            // 
            this.addNewWorkerFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.addNewWorkerFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.addNewWorkerFormLabel.ForeColor = System.Drawing.Color.Black;
            this.addNewWorkerFormLabel.Location = new System.Drawing.Point(0, 0);
            this.addNewWorkerFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.addNewWorkerFormLabel.Name = "addNewWorkerFormLabel";
            this.addNewWorkerFormLabel.Size = new System.Drawing.Size(728, 80);
            this.addNewWorkerFormLabel.TabIndex = 3;
            this.addNewWorkerFormLabel.Text = "Введите данные нового сотрудника";
            this.addNewWorkerFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newWorkerNameLabel
            // 
            this.newWorkerNameLabel.BackColor = System.Drawing.Color.MintCream;
            this.newWorkerNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWorkerNameLabel.ForeColor = System.Drawing.Color.Black;
            this.newWorkerNameLabel.Location = new System.Drawing.Point(16, 80);
            this.newWorkerNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newWorkerNameLabel.Name = "newWorkerNameLabel";
            this.newWorkerNameLabel.Size = new System.Drawing.Size(216, 80);
            this.newWorkerNameLabel.TabIndex = 21;
            this.newWorkerNameLabel.Text = "ФИО";
            this.newWorkerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newWorkerDepartmentLabel
            // 
            this.newWorkerDepartmentLabel.BackColor = System.Drawing.Color.MintCream;
            this.newWorkerDepartmentLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWorkerDepartmentLabel.ForeColor = System.Drawing.Color.Black;
            this.newWorkerDepartmentLabel.Location = new System.Drawing.Point(16, 160);
            this.newWorkerDepartmentLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newWorkerDepartmentLabel.Name = "newWorkerDepartmentLabel";
            this.newWorkerDepartmentLabel.Size = new System.Drawing.Size(216, 80);
            this.newWorkerDepartmentLabel.TabIndex = 22;
            this.newWorkerDepartmentLabel.Text = "Отделение";
            this.newWorkerDepartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newWorkerPositionLabel
            // 
            this.newWorkerPositionLabel.BackColor = System.Drawing.Color.MintCream;
            this.newWorkerPositionLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newWorkerPositionLabel.ForeColor = System.Drawing.Color.Black;
            this.newWorkerPositionLabel.Location = new System.Drawing.Point(16, 240);
            this.newWorkerPositionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.newWorkerPositionLabel.Name = "newWorkerPositionLabel";
            this.newWorkerPositionLabel.Size = new System.Drawing.Size(216, 80);
            this.newWorkerPositionLabel.TabIndex = 23;
            this.newWorkerPositionLabel.Text = "Должность";
            this.newWorkerPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewWorkerButton
            // 
            this.addNewWorkerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.addNewWorkerButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.addNewWorkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewWorkerButton.Font = new System.Drawing.Font("Comic Sans MS", 16.8F, System.Drawing.FontStyle.Bold);
            this.addNewWorkerButton.ForeColor = System.Drawing.Color.Black;
            this.addNewWorkerButton.Location = new System.Drawing.Point(248, 344);
            this.addNewWorkerButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewWorkerButton.Name = "addNewWorkerButton";
            this.addNewWorkerButton.Size = new System.Drawing.Size(224, 80);
            this.addNewWorkerButton.TabIndex = 24;
            this.addNewWorkerButton.Text = "Нанять";
            this.addNewWorkerButton.UseVisualStyleBackColor = false;
            this.addNewWorkerButton.Click += new System.EventHandler(this.addNewWorkerButton_Click);
            // 
            // newWorkerNameTextBox
            // 
            this.newWorkerNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.8F);
            this.newWorkerNameTextBox.Location = new System.Drawing.Point(256, 100);
            this.newWorkerNameTextBox.Name = "newWorkerNameTextBox";
            this.newWorkerNameTextBox.Size = new System.Drawing.Size(448, 47);
            this.newWorkerNameTextBox.TabIndex = 25;
            // 
            // newWorkerDepartmentComboBox
            // 
            this.newWorkerDepartmentComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.newWorkerDepartmentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newWorkerDepartmentComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorkerDepartmentComboBox.FormattingEnabled = true;
            this.newWorkerDepartmentComboBox.ItemHeight = 38;
            this.newWorkerDepartmentComboBox.Location = new System.Drawing.Point(256, 180);
            this.newWorkerDepartmentComboBox.Name = "newWorkerDepartmentComboBox";
            this.newWorkerDepartmentComboBox.Size = new System.Drawing.Size(448, 46);
            this.newWorkerDepartmentComboBox.TabIndex = 26;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newWorkerPositionComboBox
            // 
            this.newWorkerPositionComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.newWorkerPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newWorkerPositionComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newWorkerPositionComboBox.FormattingEnabled = true;
            this.newWorkerPositionComboBox.ItemHeight = 38;
            this.newWorkerPositionComboBox.Items.AddRange(new object[] {
            "Оператор",
            "Кредитор"});
            this.newWorkerPositionComboBox.Location = new System.Drawing.Point(256, 260);
            this.newWorkerPositionComboBox.Name = "newWorkerPositionComboBox";
            this.newWorkerPositionComboBox.Size = new System.Drawing.Size(448, 46);
            this.newWorkerPositionComboBox.TabIndex = 27;
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
            // addNewWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(728, 437);
            this.Controls.Add(this.newWorkerPositionComboBox);
            this.Controls.Add(this.newWorkerDepartmentComboBox);
            this.Controls.Add(this.newWorkerNameTextBox);
            this.Controls.Add(this.addNewWorkerButton);
            this.Controls.Add(this.newWorkerPositionLabel);
            this.Controls.Add(this.newWorkerDepartmentLabel);
            this.Controls.Add(this.newWorkerNameLabel);
            this.Controls.Add(this.addNewWorkerFormLabel);
            this.Name = "addNewWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить нового сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewWorkerFormLabel;
        private System.Windows.Forms.Label newWorkerNameLabel;
        private System.Windows.Forms.Label newWorkerDepartmentLabel;
        private System.Windows.Forms.Label newWorkerPositionLabel;
        private System.Windows.Forms.Button addNewWorkerButton;
        private System.Windows.Forms.TextBox newWorkerNameTextBox;
        private System.Windows.Forms.ComboBox newWorkerDepartmentComboBox;
        private System.Windows.Forms.ComboBox newWorkerPositionComboBox;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource получитьДанныеОтделенийОднойСтрокойBindingSource;
        private BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойTableAdapter получитьДанныеОтделенийОднойСтрокойTableAdapter;
    }
}