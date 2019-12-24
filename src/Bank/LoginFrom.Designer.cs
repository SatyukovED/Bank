namespace Bank
{
    partial class LoginFrom
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginWelcomeLabel = new System.Windows.Forms.Label();
            this.loginAuthorizationLabel = new System.Windows.Forms.Label();
            this.loginUserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.loginUserTypeLabel = new System.Windows.Forms.Label();
            this.loginWorkerIDLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginWorkerIDTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.bankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(389, 456);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(222, 80);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginWelcomeLabel
            // 
            this.loginWelcomeLabel.BackColor = System.Drawing.Color.MintCream;
            this.loginWelcomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWelcomeLabel.ForeColor = System.Drawing.Color.Black;
            this.loginWelcomeLabel.Location = new System.Drawing.Point(0, 16);
            this.loginWelcomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginWelcomeLabel.Name = "loginWelcomeLabel";
            this.loginWelcomeLabel.Size = new System.Drawing.Size(984, 61);
            this.loginWelcomeLabel.TabIndex = 0;
            this.loginWelcomeLabel.Text = "Добро пожаловать в \"ШУЕ-банк\"";
            this.loginWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginAuthorizationLabel
            // 
            this.loginAuthorizationLabel.BackColor = System.Drawing.Color.MintCream;
            this.loginAuthorizationLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginAuthorizationLabel.ForeColor = System.Drawing.Color.Black;
            this.loginAuthorizationLabel.Location = new System.Drawing.Point(336, 128);
            this.loginAuthorizationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginAuthorizationLabel.Name = "loginAuthorizationLabel";
            this.loginAuthorizationLabel.Size = new System.Drawing.Size(320, 40);
            this.loginAuthorizationLabel.TabIndex = 1;
            this.loginAuthorizationLabel.Text = "Авторизация";
            this.loginAuthorizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginUserTypeComboBox
            // 
            this.loginUserTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.loginUserTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loginUserTypeComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserTypeComboBox.FormattingEnabled = true;
            this.loginUserTypeComboBox.ItemHeight = 38;
            this.loginUserTypeComboBox.Items.AddRange(new object[] {
            "Директор",
            "Банкир-оператор",
            "Банкир-кредитор"});
            this.loginUserTypeComboBox.Location = new System.Drawing.Point(520, 232);
            this.loginUserTypeComboBox.Name = "loginUserTypeComboBox";
            this.loginUserTypeComboBox.Size = new System.Drawing.Size(312, 46);
            this.loginUserTypeComboBox.TabIndex = 2;
            this.loginUserTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.loginUserTypeComboBox_SelectedIndexChanged);
            // 
            // loginUserTypeLabel
            // 
            this.loginUserTypeLabel.BackColor = System.Drawing.Color.MintCream;
            this.loginUserTypeLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginUserTypeLabel.ForeColor = System.Drawing.Color.Black;
            this.loginUserTypeLabel.Location = new System.Drawing.Point(160, 232);
            this.loginUserTypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginUserTypeLabel.Name = "loginUserTypeLabel";
            this.loginUserTypeLabel.Size = new System.Drawing.Size(320, 46);
            this.loginUserTypeLabel.TabIndex = 3;
            this.loginUserTypeLabel.Text = "Тип аккаунта";
            this.loginUserTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginWorkerIDLabel
            // 
            this.loginWorkerIDLabel.BackColor = System.Drawing.Color.MintCream;
            this.loginWorkerIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWorkerIDLabel.ForeColor = System.Drawing.Color.Black;
            this.loginWorkerIDLabel.Location = new System.Drawing.Point(160, 328);
            this.loginWorkerIDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginWorkerIDLabel.Name = "loginWorkerIDLabel";
            this.loginWorkerIDLabel.Size = new System.Drawing.Size(320, 46);
            this.loginWorkerIDLabel.TabIndex = 4;
            this.loginWorkerIDLabel.Text = "ID сотрудника";
            this.loginWorkerIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginWorkerIDLabel.Visible = false;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.BackColor = System.Drawing.Color.MintCream;
            this.loginPasswordLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.loginPasswordLabel.Location = new System.Drawing.Point(160, 328);
            this.loginPasswordLabel.Margin = new System.Windows.Forms.Padding(0);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(320, 46);
            this.loginPasswordLabel.TabIndex = 5;
            this.loginPasswordLabel.Text = "Пароль";
            this.loginPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginPasswordLabel.Visible = false;
            // 
            // loginWorkerIDTextBox
            // 
            this.loginWorkerIDTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginWorkerIDTextBox.Location = new System.Drawing.Point(520, 328);
            this.loginWorkerIDTextBox.Name = "loginWorkerIDTextBox";
            this.loginWorkerIDTextBox.Size = new System.Drawing.Size(312, 45);
            this.loginWorkerIDTextBox.TabIndex = 6;
            this.loginWorkerIDTextBox.Visible = false;
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(520, 328);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.Size = new System.Drawing.Size(312, 45);
            this.loginPasswordTextBox.TabIndex = 7;
            this.loginPasswordTextBox.Visible = false;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bankDataSetBindingSource
            // 
            this.bankDataSetBindingSource.DataSource = this.bankDataSet;
            this.bankDataSetBindingSource.Position = 0;
            // 
            // LoginFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.loginUserTypeLabel);
            this.Controls.Add(this.loginUserTypeComboBox);
            this.Controls.Add(this.loginAuthorizationLabel);
            this.Controls.Add(this.loginWelcomeLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginWorkerIDLabel);
            this.Controls.Add(this.loginWorkerIDTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginWelcomeLabel;
        private System.Windows.Forms.Label loginAuthorizationLabel;
        private System.Windows.Forms.ComboBox loginUserTypeComboBox;
        private System.Windows.Forms.Label loginUserTypeLabel;
        private System.Windows.Forms.Label loginWorkerIDLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginWorkerIDTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.ToolTip passwordToolTip;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource bankDataSetBindingSource;
    }
}

