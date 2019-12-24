namespace Bank
{
    partial class CreditorForm
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
            this.creditorClientsWithCreditsPage = new System.Windows.Forms.TabPage();
            this.creditorGoToMainPageFromClientsWithCreditsPageButton = new System.Windows.Forms.Button();
            this.creditorClientsWithCreditsGrid = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.creditorShowClientsWithDebtButton = new System.Windows.Forms.Button();
            this.creditorHideClientsWithDebtButton = new System.Windows.Forms.Button();
            this.creditorClientsWithDebtGrid = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКредитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.клиентыИмеющиеКредитыСЗадолженностьюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditorShowFullClientWithDebtCreditsInfoButton = new System.Windows.Forms.Button();
            this.creditorShowFullClientCreditsInfoButton = new System.Windows.Forms.Button();
            this.creditorCreditRequestsPage = new System.Windows.Forms.TabPage();
            this.creditorRejectCreditRequestButton = new System.Windows.Forms.Button();
            this.creditorApproveCreditRequestButton = new System.Windows.Forms.Button();
            this.creditorShowShortClientCreditsInfoButton = new System.Windows.Forms.Button();
            this.creditorGoToMainPageFromCreditRequestsPageButton = new System.Windows.Forms.Button();
            this.creditorCreditRequestsGrid = new System.Windows.Forms.DataGridView();
            this.iDЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусЗаявкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаКредитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сортированныеЗаявкиНаКредитBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.creditorMainPage = new System.Windows.Forms.TabPage();
            this.creditorShowClientsWithCreditsButton = new System.Windows.Forms.Button();
            this.creditorShowCreditRequestsButton = new System.Windows.Forms.Button();
            this.creditorTabControl = new System.Windows.Forms.TabControl();
            this.сортированныеЗаявкиНаКредитTableAdapter = new Bank.BankDataSetTableAdapters.СортированныеЗаявкиНаКредитTableAdapter();
            this.клиентыИмеющиеКредитыСЗадолженностьюTableAdapter = new Bank.BankDataSetTableAdapters.КлиентыИмеющиеКредитыСЗадолженностьюTableAdapter();
            this.количествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter = new Bank.BankDataSetTableAdapters.КоличествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter();
            this.creditorClientsWithCreditsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditorClientsWithCreditsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditorClientsWithDebtGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыИмеющиеКредитыСЗадолженностьюBindingSource)).BeginInit();
            this.creditorCreditRequestsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.creditorCreditRequestsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортированныеЗаявкиНаКредитBindingSource)).BeginInit();
            this.creditorMainPage.SuspendLayout();
            this.creditorTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // creditorClientsWithCreditsPage
            // 
            this.creditorClientsWithCreditsPage.BackColor = System.Drawing.Color.MintCream;
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorGoToMainPageFromClientsWithCreditsPageButton);
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorClientsWithCreditsGrid);
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorShowClientsWithDebtButton);
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorHideClientsWithDebtButton);
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorClientsWithDebtGrid);
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorShowFullClientWithDebtCreditsInfoButton);
            this.creditorClientsWithCreditsPage.Controls.Add(this.creditorShowFullClientCreditsInfoButton);
            this.creditorClientsWithCreditsPage.Location = new System.Drawing.Point(4, 25);
            this.creditorClientsWithCreditsPage.Name = "creditorClientsWithCreditsPage";
            this.creditorClientsWithCreditsPage.Padding = new System.Windows.Forms.Padding(3);
            this.creditorClientsWithCreditsPage.Size = new System.Drawing.Size(974, 524);
            this.creditorClientsWithCreditsPage.TabIndex = 2;
            this.creditorClientsWithCreditsPage.Text = "Клиенты";
            // 
            // creditorGoToMainPageFromClientsWithCreditsPageButton
            // 
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.ForeColor = System.Drawing.Color.Black;
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Location = new System.Drawing.Point(40, 420);
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Name = "creditorGoToMainPageFromClientsWithCreditsPageButton";
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Size = new System.Drawing.Size(222, 80);
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.TabIndex = 2;
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Text = "На главную";
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.UseVisualStyleBackColor = false;
            this.creditorGoToMainPageFromClientsWithCreditsPageButton.Click += new System.EventHandler(this.creditorGoToMainPageFromClientsWithCreditsPageButton_Click);
            // 
            // creditorClientsWithCreditsGrid
            // 
            this.creditorClientsWithCreditsGrid.AllowUserToAddRows = false;
            this.creditorClientsWithCreditsGrid.AllowUserToDeleteRows = false;
            this.creditorClientsWithCreditsGrid.AutoGenerateColumns = false;
            this.creditorClientsWithCreditsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.creditorClientsWithCreditsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditorClientsWithCreditsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn1,
            this.фИОDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn});
            this.creditorClientsWithCreditsGrid.DataSource = this.количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource;
            this.creditorClientsWithCreditsGrid.Location = new System.Drawing.Point(40, 16);
            this.creditorClientsWithCreditsGrid.Name = "creditorClientsWithCreditsGrid";
            this.creditorClientsWithCreditsGrid.ReadOnly = true;
            this.creditorClientsWithCreditsGrid.RowTemplate.Height = 24;
            this.creditorClientsWithCreditsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.creditorClientsWithCreditsGrid.Size = new System.Drawing.Size(640, 385);
            this.creditorClientsWithCreditsGrid.TabIndex = 17;
            this.creditorClientsWithCreditsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.creditorClientsWithCreditsGrid_MouseClick);
            // 
            // iDКлиентаDataGridViewTextBoxColumn1
            // 
            this.iDКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn1.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn1.Name = "iDКлиентаDataGridViewTextBoxColumn1";
            this.iDКлиентаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDКлиентаDataGridViewTextBoxColumn1.Width = 106;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 71;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусDataGridViewTextBoxColumn.Width = 82;
            // 
            // количествоАктивныхКредитовDataGridViewTextBoxColumn
            // 
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn.DataPropertyName = "Количество активных кредитов";
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn.HeaderText = "Количество активных кредитов";
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn.Name = "количествоАктивныхКредитовDataGridViewTextBoxColumn";
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоАктивныхКредитовDataGridViewTextBoxColumn.Width = 168;
            // 
            // количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource
            // 
            this.количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource.DataMember = "КоличествоАктивныхКредитовКлиентовСФИОИСтатусом";
            this.количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // creditorShowClientsWithDebtButton
            // 
            this.creditorShowClientsWithDebtButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorShowClientsWithDebtButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorShowClientsWithDebtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorShowClientsWithDebtButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorShowClientsWithDebtButton.ForeColor = System.Drawing.Color.Black;
            this.creditorShowClientsWithDebtButton.Location = new System.Drawing.Point(720, 48);
            this.creditorShowClientsWithDebtButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorShowClientsWithDebtButton.Name = "creditorShowClientsWithDebtButton";
            this.creditorShowClientsWithDebtButton.Size = new System.Drawing.Size(216, 144);
            this.creditorShowClientsWithDebtButton.TabIndex = 16;
            this.creditorShowClientsWithDebtButton.Text = "Найти должников";
            this.creditorShowClientsWithDebtButton.UseVisualStyleBackColor = false;
            this.creditorShowClientsWithDebtButton.Click += new System.EventHandler(this.creditorShowClientsWithDebtButton_Click);
            // 
            // creditorHideClientsWithDebtButton
            // 
            this.creditorHideClientsWithDebtButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorHideClientsWithDebtButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorHideClientsWithDebtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorHideClientsWithDebtButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorHideClientsWithDebtButton.ForeColor = System.Drawing.Color.Black;
            this.creditorHideClientsWithDebtButton.Location = new System.Drawing.Point(720, 48);
            this.creditorHideClientsWithDebtButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorHideClientsWithDebtButton.Name = "creditorHideClientsWithDebtButton";
            this.creditorHideClientsWithDebtButton.Size = new System.Drawing.Size(216, 144);
            this.creditorHideClientsWithDebtButton.TabIndex = 18;
            this.creditorHideClientsWithDebtButton.Text = "Скрыть должников";
            this.creditorHideClientsWithDebtButton.UseVisualStyleBackColor = false;
            this.creditorHideClientsWithDebtButton.Visible = false;
            this.creditorHideClientsWithDebtButton.Click += new System.EventHandler(this.creditorHideClientsWithDebtButton_Click);
            // 
            // creditorClientsWithDebtGrid
            // 
            this.creditorClientsWithDebtGrid.AllowUserToAddRows = false;
            this.creditorClientsWithDebtGrid.AllowUserToDeleteRows = false;
            this.creditorClientsWithDebtGrid.AutoGenerateColumns = false;
            this.creditorClientsWithDebtGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.creditorClientsWithDebtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditorClientsWithDebtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn2,
            this.фИОDataGridViewTextBoxColumn1,
            this.номерКредитаDataGridViewTextBoxColumn});
            this.creditorClientsWithDebtGrid.DataSource = this.клиентыИмеющиеКредитыСЗадолженностьюBindingSource;
            this.creditorClientsWithDebtGrid.Location = new System.Drawing.Point(40, 16);
            this.creditorClientsWithDebtGrid.Name = "creditorClientsWithDebtGrid";
            this.creditorClientsWithDebtGrid.ReadOnly = true;
            this.creditorClientsWithDebtGrid.RowTemplate.Height = 24;
            this.creditorClientsWithDebtGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.creditorClientsWithDebtGrid.Size = new System.Drawing.Size(640, 385);
            this.creditorClientsWithDebtGrid.TabIndex = 20;
            this.creditorClientsWithDebtGrid.Visible = false;
            this.creditorClientsWithDebtGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.creditorClientsWithDebtGrid_MouseClick);
            // 
            // iDКлиентаDataGridViewTextBoxColumn2
            // 
            this.iDКлиентаDataGridViewTextBoxColumn2.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn2.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn2.Name = "iDКлиентаDataGridViewTextBoxColumn2";
            this.iDКлиентаDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDКлиентаDataGridViewTextBoxColumn2.Width = 106;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn1.Width = 71;
            // 
            // номерКредитаDataGridViewTextBoxColumn
            // 
            this.номерКредитаDataGridViewTextBoxColumn.DataPropertyName = "Номер кредита";
            this.номерКредитаDataGridViewTextBoxColumn.HeaderText = "Номер кредита";
            this.номерКредитаDataGridViewTextBoxColumn.Name = "номерКредитаDataGridViewTextBoxColumn";
            this.номерКредитаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерКредитаDataGridViewTextBoxColumn.Width = 127;
            // 
            // клиентыИмеющиеКредитыСЗадолженностьюBindingSource
            // 
            this.клиентыИмеющиеКредитыСЗадолженностьюBindingSource.DataMember = "КлиентыИмеющиеКредитыСЗадолженностью";
            this.клиентыИмеющиеКредитыСЗадолженностьюBindingSource.DataSource = this.bankDataSet;
            // 
            // creditorShowFullClientWithDebtCreditsInfoButton
            // 
            this.creditorShowFullClientWithDebtCreditsInfoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorShowFullClientWithDebtCreditsInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorShowFullClientWithDebtCreditsInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorShowFullClientWithDebtCreditsInfoButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorShowFullClientWithDebtCreditsInfoButton.ForeColor = System.Drawing.Color.Black;
            this.creditorShowFullClientWithDebtCreditsInfoButton.Location = new System.Drawing.Point(720, 224);
            this.creditorShowFullClientWithDebtCreditsInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorShowFullClientWithDebtCreditsInfoButton.Name = "creditorShowFullClientWithDebtCreditsInfoButton";
            this.creditorShowFullClientWithDebtCreditsInfoButton.Size = new System.Drawing.Size(216, 144);
            this.creditorShowFullClientWithDebtCreditsInfoButton.TabIndex = 19;
            this.creditorShowFullClientWithDebtCreditsInfoButton.Text = "Подробная информация о клиенте";
            this.creditorShowFullClientWithDebtCreditsInfoButton.UseVisualStyleBackColor = false;
            this.creditorShowFullClientWithDebtCreditsInfoButton.Visible = false;
            this.creditorShowFullClientWithDebtCreditsInfoButton.Click += new System.EventHandler(this.creditorShowFullClientWithDebtCreditsInfoButton_Click);
            // 
            // creditorShowFullClientCreditsInfoButton
            // 
            this.creditorShowFullClientCreditsInfoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorShowFullClientCreditsInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorShowFullClientCreditsInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorShowFullClientCreditsInfoButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorShowFullClientCreditsInfoButton.ForeColor = System.Drawing.Color.Black;
            this.creditorShowFullClientCreditsInfoButton.Location = new System.Drawing.Point(720, 224);
            this.creditorShowFullClientCreditsInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorShowFullClientCreditsInfoButton.Name = "creditorShowFullClientCreditsInfoButton";
            this.creditorShowFullClientCreditsInfoButton.Size = new System.Drawing.Size(216, 144);
            this.creditorShowFullClientCreditsInfoButton.TabIndex = 15;
            this.creditorShowFullClientCreditsInfoButton.Text = "Подробная информация о клиенте";
            this.creditorShowFullClientCreditsInfoButton.UseVisualStyleBackColor = false;
            this.creditorShowFullClientCreditsInfoButton.Click += new System.EventHandler(this.creditorShowFullClientCreditsInfoButton_Click);
            // 
            // creditorCreditRequestsPage
            // 
            this.creditorCreditRequestsPage.BackColor = System.Drawing.Color.MintCream;
            this.creditorCreditRequestsPage.Controls.Add(this.creditorRejectCreditRequestButton);
            this.creditorCreditRequestsPage.Controls.Add(this.creditorApproveCreditRequestButton);
            this.creditorCreditRequestsPage.Controls.Add(this.creditorShowShortClientCreditsInfoButton);
            this.creditorCreditRequestsPage.Controls.Add(this.creditorGoToMainPageFromCreditRequestsPageButton);
            this.creditorCreditRequestsPage.Controls.Add(this.creditorCreditRequestsGrid);
            this.creditorCreditRequestsPage.Location = new System.Drawing.Point(4, 25);
            this.creditorCreditRequestsPage.Name = "creditorCreditRequestsPage";
            this.creditorCreditRequestsPage.Padding = new System.Windows.Forms.Padding(3);
            this.creditorCreditRequestsPage.Size = new System.Drawing.Size(974, 524);
            this.creditorCreditRequestsPage.TabIndex = 1;
            this.creditorCreditRequestsPage.Text = "Заявки на кредит";
            // 
            // creditorRejectCreditRequestButton
            // 
            this.creditorRejectCreditRequestButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorRejectCreditRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorRejectCreditRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorRejectCreditRequestButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorRejectCreditRequestButton.ForeColor = System.Drawing.Color.Black;
            this.creditorRejectCreditRequestButton.Location = new System.Drawing.Point(510, 400);
            this.creditorRejectCreditRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorRejectCreditRequestButton.Name = "creditorRejectCreditRequestButton";
            this.creditorRejectCreditRequestButton.Size = new System.Drawing.Size(190, 112);
            this.creditorRejectCreditRequestButton.TabIndex = 17;
            this.creditorRejectCreditRequestButton.Text = "Отклонить";
            this.creditorRejectCreditRequestButton.UseVisualStyleBackColor = false;
            this.creditorRejectCreditRequestButton.Visible = false;
            this.creditorRejectCreditRequestButton.Click += new System.EventHandler(this.creditorRejectCreditRequestButton_Click);
            // 
            // creditorApproveCreditRequestButton
            // 
            this.creditorApproveCreditRequestButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorApproveCreditRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorApproveCreditRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorApproveCreditRequestButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorApproveCreditRequestButton.ForeColor = System.Drawing.Color.Black;
            this.creditorApproveCreditRequestButton.Location = new System.Drawing.Point(312, 400);
            this.creditorApproveCreditRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorApproveCreditRequestButton.Name = "creditorApproveCreditRequestButton";
            this.creditorApproveCreditRequestButton.Size = new System.Drawing.Size(190, 112);
            this.creditorApproveCreditRequestButton.TabIndex = 16;
            this.creditorApproveCreditRequestButton.Text = "Одобрить";
            this.creditorApproveCreditRequestButton.UseVisualStyleBackColor = false;
            this.creditorApproveCreditRequestButton.Visible = false;
            this.creditorApproveCreditRequestButton.Click += new System.EventHandler(this.creditorApproveCreditRequestButton_Click);
            // 
            // creditorShowShortClientCreditsInfoButton
            // 
            this.creditorShowShortClientCreditsInfoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorShowShortClientCreditsInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorShowShortClientCreditsInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorShowShortClientCreditsInfoButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorShowShortClientCreditsInfoButton.ForeColor = System.Drawing.Color.Black;
            this.creditorShowShortClientCreditsInfoButton.Location = new System.Drawing.Point(708, 400);
            this.creditorShowShortClientCreditsInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorShowShortClientCreditsInfoButton.Name = "creditorShowShortClientCreditsInfoButton";
            this.creditorShowShortClientCreditsInfoButton.Size = new System.Drawing.Size(226, 112);
            this.creditorShowShortClientCreditsInfoButton.TabIndex = 15;
            this.creditorShowShortClientCreditsInfoButton.Text = "Информация о клиенте";
            this.creditorShowShortClientCreditsInfoButton.UseVisualStyleBackColor = false;
            this.creditorShowShortClientCreditsInfoButton.Click += new System.EventHandler(this.creditorShowShortClientCreditsInfoButton_Click);
            // 
            // creditorGoToMainPageFromCreditRequestsPageButton
            // 
            this.creditorGoToMainPageFromCreditRequestsPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorGoToMainPageFromCreditRequestsPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorGoToMainPageFromCreditRequestsPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorGoToMainPageFromCreditRequestsPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorGoToMainPageFromCreditRequestsPageButton.ForeColor = System.Drawing.Color.Black;
            this.creditorGoToMainPageFromCreditRequestsPageButton.Location = new System.Drawing.Point(40, 420);
            this.creditorGoToMainPageFromCreditRequestsPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorGoToMainPageFromCreditRequestsPageButton.Name = "creditorGoToMainPageFromCreditRequestsPageButton";
            this.creditorGoToMainPageFromCreditRequestsPageButton.Size = new System.Drawing.Size(222, 80);
            this.creditorGoToMainPageFromCreditRequestsPageButton.TabIndex = 2;
            this.creditorGoToMainPageFromCreditRequestsPageButton.Text = "На главную";
            this.creditorGoToMainPageFromCreditRequestsPageButton.UseVisualStyleBackColor = false;
            this.creditorGoToMainPageFromCreditRequestsPageButton.Click += new System.EventHandler(this.creditorGoToMainPageFromCreditRequestsPageButton_Click);
            // 
            // creditorCreditRequestsGrid
            // 
            this.creditorCreditRequestsGrid.AllowUserToAddRows = false;
            this.creditorCreditRequestsGrid.AllowUserToDeleteRows = false;
            this.creditorCreditRequestsGrid.AutoGenerateColumns = false;
            this.creditorCreditRequestsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.creditorCreditRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.creditorCreditRequestsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаявкиDataGridViewTextBoxColumn,
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.статусЗаявкиDataGridViewTextBoxColumn,
            this.суммаКредитаDataGridViewTextBoxColumn,
            this.процентDataGridViewTextBoxColumn,
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn,
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn,
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn});
            this.creditorCreditRequestsGrid.DataSource = this.сортированныеЗаявкиНаКредитBindingSource;
            this.creditorCreditRequestsGrid.Location = new System.Drawing.Point(40, 16);
            this.creditorCreditRequestsGrid.Name = "creditorCreditRequestsGrid";
            this.creditorCreditRequestsGrid.ReadOnly = true;
            this.creditorCreditRequestsGrid.RowTemplate.Height = 24;
            this.creditorCreditRequestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.creditorCreditRequestsGrid.Size = new System.Drawing.Size(894, 368);
            this.creditorCreditRequestsGrid.TabIndex = 8;
            this.creditorCreditRequestsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.creditorCreditRequestsGrid_MouseClick);
            // 
            // iDЗаявкиDataGridViewTextBoxColumn
            // 
            this.iDЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "IDЗаявки";
            this.iDЗаявкиDataGridViewTextBoxColumn.HeaderText = "IDЗаявки";
            this.iDЗаявкиDataGridViewTextBoxColumn.Name = "iDЗаявкиDataGridViewTextBoxColumn";
            this.iDЗаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDЗаявкиDataGridViewTextBoxColumn.Width = 97;
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКлиентаDataGridViewTextBoxColumn.Width = 106;
            // 
            // статусЗаявкиDataGridViewTextBoxColumn
            // 
            this.статусЗаявкиDataGridViewTextBoxColumn.DataPropertyName = "СтатусЗаявки";
            this.статусЗаявкиDataGridViewTextBoxColumn.HeaderText = "СтатусЗаявки";
            this.статусЗаявкиDataGridViewTextBoxColumn.Name = "статусЗаявкиDataGridViewTextBoxColumn";
            this.статусЗаявкиDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусЗаявкиDataGridViewTextBoxColumn.Width = 129;
            // 
            // суммаКредитаDataGridViewTextBoxColumn
            // 
            this.суммаКредитаDataGridViewTextBoxColumn.DataPropertyName = "СуммаКредита";
            this.суммаКредитаDataGridViewTextBoxColumn.HeaderText = "СуммаКредита";
            this.суммаКредитаDataGridViewTextBoxColumn.Name = "суммаКредитаDataGridViewTextBoxColumn";
            this.суммаКредитаDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаКредитаDataGridViewTextBoxColumn.Width = 135;
            // 
            // процентDataGridViewTextBoxColumn
            // 
            this.процентDataGridViewTextBoxColumn.DataPropertyName = "Процент";
            this.процентDataGridViewTextBoxColumn.HeaderText = "Процент";
            this.процентDataGridViewTextBoxColumn.Name = "процентDataGridViewTextBoxColumn";
            this.процентDataGridViewTextBoxColumn.ReadOnly = true;
            this.процентDataGridViewTextBoxColumn.Width = 94;
            // 
            // срокКредитаВМесяцахDataGridViewTextBoxColumn
            // 
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.DataPropertyName = "СрокКредитаВМесяцах";
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.HeaderText = "СрокКредитаВМесяцах";
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.Name = "срокКредитаВМесяцахDataGridViewTextBoxColumn";
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.ReadOnly = true;
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.Width = 190;
            // 
            // операторПодавшийЗаявкуDataGridViewTextBoxColumn
            // 
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn.DataPropertyName = "ОператорПодавшийЗаявку";
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn.HeaderText = "ОператорПодавшийЗаявку";
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn.Name = "операторПодавшийЗаявкуDataGridViewTextBoxColumn";
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn.ReadOnly = true;
            this.операторПодавшийЗаявкуDataGridViewTextBoxColumn.Width = 217;
            // 
            // кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn
            // 
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn.DataPropertyName = "КредиторОбработавшийЗаявку";
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn.HeaderText = "КредиторОбработавшийЗаявку";
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn.Name = "кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn";
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn.ReadOnly = true;
            this.кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn.Width = 247;
            // 
            // сортированныеЗаявкиНаКредитBindingSource
            // 
            this.сортированныеЗаявкиНаКредитBindingSource.DataMember = "СортированныеЗаявкиНаКредит";
            this.сортированныеЗаявкиНаКредитBindingSource.DataSource = this.bankDataSet;
            // 
            // creditorMainPage
            // 
            this.creditorMainPage.BackColor = System.Drawing.Color.MintCream;
            this.creditorMainPage.Controls.Add(this.creditorShowClientsWithCreditsButton);
            this.creditorMainPage.Controls.Add(this.creditorShowCreditRequestsButton);
            this.creditorMainPage.Location = new System.Drawing.Point(4, 25);
            this.creditorMainPage.Name = "creditorMainPage";
            this.creditorMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.creditorMainPage.Size = new System.Drawing.Size(974, 524);
            this.creditorMainPage.TabIndex = 0;
            this.creditorMainPage.Text = "Главная страница";
            // 
            // creditorShowClientsWithCreditsButton
            // 
            this.creditorShowClientsWithCreditsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorShowClientsWithCreditsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorShowClientsWithCreditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorShowClientsWithCreditsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorShowClientsWithCreditsButton.ForeColor = System.Drawing.Color.Black;
            this.creditorShowClientsWithCreditsButton.Location = new System.Drawing.Point(528, 184);
            this.creditorShowClientsWithCreditsButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorShowClientsWithCreditsButton.Name = "creditorShowClientsWithCreditsButton";
            this.creditorShowClientsWithCreditsButton.Size = new System.Drawing.Size(366, 120);
            this.creditorShowClientsWithCreditsButton.TabIndex = 5;
            this.creditorShowClientsWithCreditsButton.Text = "Клиенты";
            this.creditorShowClientsWithCreditsButton.UseVisualStyleBackColor = false;
            this.creditorShowClientsWithCreditsButton.Click += new System.EventHandler(this.creditorShowClientsWithCreditsButton_Click);
            // 
            // creditorShowCreditRequestsButton
            // 
            this.creditorShowCreditRequestsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.creditorShowCreditRequestsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.creditorShowCreditRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditorShowCreditRequestsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.creditorShowCreditRequestsButton.ForeColor = System.Drawing.Color.Black;
            this.creditorShowCreditRequestsButton.Location = new System.Drawing.Point(80, 184);
            this.creditorShowCreditRequestsButton.Margin = new System.Windows.Forms.Padding(4);
            this.creditorShowCreditRequestsButton.Name = "creditorShowCreditRequestsButton";
            this.creditorShowCreditRequestsButton.Size = new System.Drawing.Size(368, 120);
            this.creditorShowCreditRequestsButton.TabIndex = 4;
            this.creditorShowCreditRequestsButton.Text = "Список заявок на кредит";
            this.creditorShowCreditRequestsButton.UseVisualStyleBackColor = false;
            this.creditorShowCreditRequestsButton.Click += new System.EventHandler(this.creditorShowCreditRequestsButton_Click);
            // 
            // creditorTabControl
            // 
            this.creditorTabControl.Controls.Add(this.creditorMainPage);
            this.creditorTabControl.Controls.Add(this.creditorCreditRequestsPage);
            this.creditorTabControl.Controls.Add(this.creditorClientsWithCreditsPage);
            this.creditorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.creditorTabControl.Location = new System.Drawing.Point(0, 0);
            this.creditorTabControl.Name = "creditorTabControl";
            this.creditorTabControl.SelectedIndex = 0;
            this.creditorTabControl.Size = new System.Drawing.Size(982, 553);
            this.creditorTabControl.TabIndex = 0;
            // 
            // сортированныеЗаявкиНаКредитTableAdapter
            // 
            this.сортированныеЗаявкиНаКредитTableAdapter.ClearBeforeFill = true;
            // 
            // клиентыИмеющиеКредитыСЗадолженностьюTableAdapter
            // 
            this.клиентыИмеющиеКредитыСЗадолженностьюTableAdapter.ClearBeforeFill = true;
            // 
            // количествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter
            // 
            this.количествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter.ClearBeforeFill = true;
            // 
            // CreditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.creditorTabControl);
            this.Name = "CreditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкир-кредитор";
            this.Load += new System.EventHandler(this.CreditorForm_Load);
            this.creditorClientsWithCreditsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditorClientsWithCreditsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creditorClientsWithDebtGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыИмеющиеКредитыСЗадолженностьюBindingSource)).EndInit();
            this.creditorCreditRequestsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.creditorCreditRequestsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сортированныеЗаявкиНаКредитBindingSource)).EndInit();
            this.creditorMainPage.ResumeLayout(false);
            this.creditorTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage creditorClientsWithCreditsPage;
        private System.Windows.Forms.Button creditorGoToMainPageFromClientsWithCreditsPageButton;
        private System.Windows.Forms.TabPage creditorCreditRequestsPage;
        private System.Windows.Forms.Button creditorGoToMainPageFromCreditRequestsPageButton;
        private System.Windows.Forms.TabPage creditorMainPage;
        private System.Windows.Forms.Button creditorShowClientsWithCreditsButton;
        private System.Windows.Forms.Button creditorShowCreditRequestsButton;
        private System.Windows.Forms.TabControl creditorTabControl;
        private System.Windows.Forms.DataGridView creditorCreditRequestsGrid;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.Button creditorShowClientsWithDebtButton;
        private System.Windows.Forms.Button creditorShowFullClientCreditsInfoButton;
        private System.Windows.Forms.Button creditorRejectCreditRequestButton;
        private System.Windows.Forms.Button creditorApproveCreditRequestButton;
        private System.Windows.Forms.Button creditorShowShortClientCreditsInfoButton;
        private System.Windows.Forms.DataGridView creditorClientsWithCreditsGrid;
        private System.Windows.Forms.Button creditorHideClientsWithDebtButton;
        private System.Windows.Forms.Button creditorShowFullClientWithDebtCreditsInfoButton;
        private System.Windows.Forms.DataGridView creditorClientsWithDebtGrid;
        private System.Windows.Forms.BindingSource сортированныеЗаявкиНаКредитBindingSource;
        private BankDataSetTableAdapters.СортированныеЗаявкиНаКредитTableAdapter сортированныеЗаявкиНаКредитTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусЗаявкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаКредитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокКредитаВМесяцахDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn операторПодавшийЗаявкуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кредиторОбработавшийЗаявкуDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource клиентыИмеющиеКредитыСЗадолженностьюBindingSource;
        private BankDataSetTableAdapters.КлиентыИмеющиеКредитыСЗадолженностьюTableAdapter клиентыИмеющиеКредитыСЗадолженностьюTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКредитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource количествоАктивныхКредитовКлиентовСФИОИСтатусомBindingSource;
        private BankDataSetTableAdapters.КоличествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter количествоАктивныхКредитовКлиентовСФИОИСтатусомTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоАктивныхКредитовDataGridViewTextBoxColumn;
    }
}