namespace Bank
{
    partial class MoveWorkerForm
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
            this.moveWorkerButton = new System.Windows.Forms.Button();
            this.moveWorkerFormLabel = new System.Windows.Forms.Label();
            this.departmentsToMoveWorkerComboBox = new System.Windows.Forms.ComboBox();
            this.bankDataSet = new Bank.BankDataSet();
            this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // moveWorkerButton
            // 
            this.moveWorkerButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.moveWorkerButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.moveWorkerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveWorkerButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.moveWorkerButton.ForeColor = System.Drawing.Color.Black;
            this.moveWorkerButton.Location = new System.Drawing.Point(176, 192);
            this.moveWorkerButton.Margin = new System.Windows.Forms.Padding(4);
            this.moveWorkerButton.Name = "moveWorkerButton";
            this.moveWorkerButton.Size = new System.Drawing.Size(200, 56);
            this.moveWorkerButton.TabIndex = 13;
            this.moveWorkerButton.Text = "Перевести";
            this.moveWorkerButton.UseVisualStyleBackColor = false;
            this.moveWorkerButton.Click += new System.EventHandler(this.moveWorkerButton_Click);
            // 
            // moveWorkerFormLabel
            // 
            this.moveWorkerFormLabel.BackColor = System.Drawing.Color.MintCream;
            this.moveWorkerFormLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.moveWorkerFormLabel.ForeColor = System.Drawing.Color.Black;
            this.moveWorkerFormLabel.Location = new System.Drawing.Point(32, 0);
            this.moveWorkerFormLabel.Margin = new System.Windows.Forms.Padding(0);
            this.moveWorkerFormLabel.Name = "moveWorkerFormLabel";
            this.moveWorkerFormLabel.Size = new System.Drawing.Size(472, 104);
            this.moveWorkerFormLabel.TabIndex = 12;
            this.moveWorkerFormLabel.Text = "Выберите отделение, в которое хотите перевести сотрудника";
            this.moveWorkerFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // departmentsToMoveWorkerComboBox
            // 
            this.departmentsToMoveWorkerComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.departmentsToMoveWorkerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.departmentsToMoveWorkerComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsToMoveWorkerComboBox.FormattingEnabled = true;
            this.departmentsToMoveWorkerComboBox.ItemHeight = 38;
            this.departmentsToMoveWorkerComboBox.Location = new System.Drawing.Point(40, 112);
            this.departmentsToMoveWorkerComboBox.Name = "departmentsToMoveWorkerComboBox";
            this.departmentsToMoveWorkerComboBox.Size = new System.Drawing.Size(464, 46);
            this.departmentsToMoveWorkerComboBox.TabIndex = 20;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource
            // 
            this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource.DataMember = "ПолучитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудником";
            this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource.DataSource = this.bankDataSet;
            // 
            // получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter
            // 
            this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter.ClearBeforeFill = true;
            // 
            // MoveWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(545, 264);
            this.Controls.Add(this.departmentsToMoveWorkerComboBox);
            this.Controls.Add(this.moveWorkerButton);
            this.Controls.Add(this.moveWorkerFormLabel);
            this.Name = "MoveWorkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Перевод сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button moveWorkerButton;
        private System.Windows.Forms.Label moveWorkerFormLabel;
        private System.Windows.Forms.ComboBox departmentsToMoveWorkerComboBox;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомBindingSource;
        private BankDataSetTableAdapters.ПолучитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter;
    }
}