namespace Bank
{
    partial class OperatorForm
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
            this.operatorPotentialClientsPage = new System.Windows.Forms.TabPage();
            this.operatorGoToMainPageFromPotentialClientsPageButton = new System.Windows.Forms.Button();
            this.operatorOpenCardButton = new System.Windows.Forms.Button();
            this.operatorOpenCreditRequestButton = new System.Windows.Forms.Button();
            this.operatorOpenContributionButton = new System.Windows.Forms.Button();
            this.operatorPotentialClientsGrid = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.остутствующиеАктивныеСчетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet1 = new Bank.BankDataSet();
            this.operatorClientsPage = new System.Windows.Forms.TabPage();
            this.operatorAddNewClientButton = new System.Windows.Forms.Button();
            this.operatorGoToMainPageFromClientsPageButton = new System.Windows.Forms.Button();
            this.operatorShowFullClientInfoButton = new System.Windows.Forms.Button();
            this.operatorClientsGrid = new System.Windows.Forms.DataGridView();
            this.iDКлиентаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доходDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.получитьСписокКлиентовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.operatorTabControl = new System.Windows.Forms.TabControl();
            this.operatorMainPage = new System.Windows.Forms.TabPage();
            this.operatorShowPotentialClientsButton = new System.Windows.Forms.Button();
            this.operatorShowClientsButton = new System.Windows.Forms.Button();
            this.получитьСписокКлиентовTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьСписокКлиентовTableAdapter();
            this.остутствующиеАктивныеСчетаTableAdapter = new Bank.BankDataSetTableAdapters.ОстутствующиеАктивныеСчетаTableAdapter();
            this.operatorPotentialClientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorPotentialClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.остутствующиеАктивныеСчетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            this.operatorClientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operatorClientsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСписокКлиентовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            this.operatorTabControl.SuspendLayout();
            this.operatorMainPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // operatorPotentialClientsPage
            // 
            this.operatorPotentialClientsPage.BackColor = System.Drawing.Color.MintCream;
            this.operatorPotentialClientsPage.Controls.Add(this.operatorGoToMainPageFromPotentialClientsPageButton);
            this.operatorPotentialClientsPage.Controls.Add(this.operatorPotentialClientsGrid);
            this.operatorPotentialClientsPage.Controls.Add(this.operatorOpenCreditRequestButton);
            this.operatorPotentialClientsPage.Controls.Add(this.operatorOpenContributionButton);
            this.operatorPotentialClientsPage.Controls.Add(this.operatorOpenCardButton);
            this.operatorPotentialClientsPage.Location = new System.Drawing.Point(4, 25);
            this.operatorPotentialClientsPage.Name = "operatorPotentialClientsPage";
            this.operatorPotentialClientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.operatorPotentialClientsPage.Size = new System.Drawing.Size(974, 524);
            this.operatorPotentialClientsPage.TabIndex = 3;
            this.operatorPotentialClientsPage.Text = "Потенциальные клиенты";
            // 
            // operatorGoToMainPageFromPotentialClientsPageButton
            // 
            this.operatorGoToMainPageFromPotentialClientsPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorGoToMainPageFromPotentialClientsPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorGoToMainPageFromPotentialClientsPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorGoToMainPageFromPotentialClientsPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorGoToMainPageFromPotentialClientsPageButton.ForeColor = System.Drawing.Color.Black;
            this.operatorGoToMainPageFromPotentialClientsPageButton.Location = new System.Drawing.Point(40, 420);
            this.operatorGoToMainPageFromPotentialClientsPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorGoToMainPageFromPotentialClientsPageButton.Name = "operatorGoToMainPageFromPotentialClientsPageButton";
            this.operatorGoToMainPageFromPotentialClientsPageButton.Size = new System.Drawing.Size(222, 80);
            this.operatorGoToMainPageFromPotentialClientsPageButton.TabIndex = 4;
            this.operatorGoToMainPageFromPotentialClientsPageButton.Text = "На главную";
            this.operatorGoToMainPageFromPotentialClientsPageButton.UseVisualStyleBackColor = false;
            this.operatorGoToMainPageFromPotentialClientsPageButton.Click += new System.EventHandler(this.operatorGoToMainPageFromPotentialClientsPageButton_Click);
            // 
            // operatorOpenCardButton
            // 
            this.operatorOpenCardButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorOpenCardButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorOpenCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorOpenCardButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorOpenCardButton.ForeColor = System.Drawing.Color.Black;
            this.operatorOpenCardButton.Location = new System.Drawing.Point(720, 136);
            this.operatorOpenCardButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorOpenCardButton.Name = "operatorOpenCardButton";
            this.operatorOpenCardButton.Size = new System.Drawing.Size(216, 144);
            this.operatorOpenCardButton.TabIndex = 22;
            this.operatorOpenCardButton.Text = "Выпустить карту";
            this.operatorOpenCardButton.UseVisualStyleBackColor = false;
            this.operatorOpenCardButton.Visible = false;
            this.operatorOpenCardButton.Click += new System.EventHandler(this.operatorOpenCardButton_Click);
            // 
            // operatorOpenCreditRequestButton
            // 
            this.operatorOpenCreditRequestButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorOpenCreditRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorOpenCreditRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorOpenCreditRequestButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorOpenCreditRequestButton.ForeColor = System.Drawing.Color.Black;
            this.operatorOpenCreditRequestButton.Location = new System.Drawing.Point(720, 136);
            this.operatorOpenCreditRequestButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorOpenCreditRequestButton.Name = "operatorOpenCreditRequestButton";
            this.operatorOpenCreditRequestButton.Size = new System.Drawing.Size(216, 144);
            this.operatorOpenCreditRequestButton.TabIndex = 25;
            this.operatorOpenCreditRequestButton.Text = "Подать заявку на кредит";
            this.operatorOpenCreditRequestButton.UseVisualStyleBackColor = false;
            this.operatorOpenCreditRequestButton.Visible = false;
            this.operatorOpenCreditRequestButton.Click += new System.EventHandler(this.operatorOpenCreditRequestButton_Click);
            // 
            // operatorOpenContributionButton
            // 
            this.operatorOpenContributionButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorOpenContributionButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorOpenContributionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorOpenContributionButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorOpenContributionButton.ForeColor = System.Drawing.Color.Black;
            this.operatorOpenContributionButton.Location = new System.Drawing.Point(720, 136);
            this.operatorOpenContributionButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorOpenContributionButton.Name = "operatorOpenContributionButton";
            this.operatorOpenContributionButton.Size = new System.Drawing.Size(216, 144);
            this.operatorOpenContributionButton.TabIndex = 24;
            this.operatorOpenContributionButton.Text = "Открыть вклад";
            this.operatorOpenContributionButton.UseVisualStyleBackColor = false;
            this.operatorOpenContributionButton.Visible = false;
            this.operatorOpenContributionButton.Click += new System.EventHandler(this.operatorOpenContributionButton_Click);
            // 
            // operatorPotentialClientsGrid
            // 
            this.operatorPotentialClientsGrid.AllowUserToAddRows = false;
            this.operatorPotentialClientsGrid.AllowUserToDeleteRows = false;
            this.operatorPotentialClientsGrid.AutoGenerateColumns = false;
            this.operatorPotentialClientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.operatorPotentialClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatorPotentialClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn1,
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn});
            this.operatorPotentialClientsGrid.DataSource = this.остутствующиеАктивныеСчетаBindingSource;
            this.operatorPotentialClientsGrid.Location = new System.Drawing.Point(40, 16);
            this.operatorPotentialClientsGrid.Name = "operatorPotentialClientsGrid";
            this.operatorPotentialClientsGrid.ReadOnly = true;
            this.operatorPotentialClientsGrid.RowTemplate.Height = 24;
            this.operatorPotentialClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operatorPotentialClientsGrid.Size = new System.Drawing.Size(640, 385);
            this.operatorPotentialClientsGrid.TabIndex = 23;
            this.operatorPotentialClientsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.operatorPotentialClientsGrid_CellMouseClick);
            // 
            // iDКлиентаDataGridViewTextBoxColumn1
            // 
            this.iDКлиентаDataGridViewTextBoxColumn1.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn1.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn1.Name = "iDКлиентаDataGridViewTextBoxColumn1";
            this.iDКлиентаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDКлиентаDataGridViewTextBoxColumn1.Width = 106;
            // 
            // отсутствующийАктивныйСчетDataGridViewTextBoxColumn
            // 
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn.DataPropertyName = "Отсутствующий активный счет";
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn.HeaderText = "Отсутствующий активный счет";
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn.Name = "отсутствующийАктивныйСчетDataGridViewTextBoxColumn";
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn.ReadOnly = true;
            this.отсутствующийАктивныйСчетDataGridViewTextBoxColumn.Width = 193;
            // 
            // остутствующиеАктивныеСчетаBindingSource
            // 
            this.остутствующиеАктивныеСчетаBindingSource.DataMember = "ОстутствующиеАктивныеСчета";
            this.остутствующиеАктивныеСчетаBindingSource.DataSource = this.bankDataSet1;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "BankDataSet";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorClientsPage
            // 
            this.operatorClientsPage.BackColor = System.Drawing.Color.MintCream;
            this.operatorClientsPage.Controls.Add(this.operatorAddNewClientButton);
            this.operatorClientsPage.Controls.Add(this.operatorGoToMainPageFromClientsPageButton);
            this.operatorClientsPage.Controls.Add(this.operatorShowFullClientInfoButton);
            this.operatorClientsPage.Controls.Add(this.operatorClientsGrid);
            this.operatorClientsPage.Location = new System.Drawing.Point(4, 25);
            this.operatorClientsPage.Name = "operatorClientsPage";
            this.operatorClientsPage.Padding = new System.Windows.Forms.Padding(3);
            this.operatorClientsPage.Size = new System.Drawing.Size(974, 524);
            this.operatorClientsPage.TabIndex = 1;
            this.operatorClientsPage.Text = "Клиенты";
            // 
            // operatorAddNewClientButton
            // 
            this.operatorAddNewClientButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorAddNewClientButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorAddNewClientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorAddNewClientButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorAddNewClientButton.ForeColor = System.Drawing.Color.Black;
            this.operatorAddNewClientButton.Location = new System.Drawing.Point(720, 230);
            this.operatorAddNewClientButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorAddNewClientButton.Name = "operatorAddNewClientButton";
            this.operatorAddNewClientButton.Size = new System.Drawing.Size(216, 144);
            this.operatorAddNewClientButton.TabIndex = 22;
            this.operatorAddNewClientButton.Text = "Добавить клиента";
            this.operatorAddNewClientButton.UseVisualStyleBackColor = false;
            this.operatorAddNewClientButton.Click += new System.EventHandler(this.operatorAddClientButton_Click);
            // 
            // operatorGoToMainPageFromClientsPageButton
            // 
            this.operatorGoToMainPageFromClientsPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorGoToMainPageFromClientsPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorGoToMainPageFromClientsPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorGoToMainPageFromClientsPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorGoToMainPageFromClientsPageButton.ForeColor = System.Drawing.Color.Black;
            this.operatorGoToMainPageFromClientsPageButton.Location = new System.Drawing.Point(40, 420);
            this.operatorGoToMainPageFromClientsPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorGoToMainPageFromClientsPageButton.Name = "operatorGoToMainPageFromClientsPageButton";
            this.operatorGoToMainPageFromClientsPageButton.Size = new System.Drawing.Size(222, 80);
            this.operatorGoToMainPageFromClientsPageButton.TabIndex = 3;
            this.operatorGoToMainPageFromClientsPageButton.Text = "На главную";
            this.operatorGoToMainPageFromClientsPageButton.UseVisualStyleBackColor = false;
            this.operatorGoToMainPageFromClientsPageButton.Click += new System.EventHandler(this.operatorGoToMainPageFromClientsPageButton_Click);
            // 
            // operatorShowFullClientInfoButton
            // 
            this.operatorShowFullClientInfoButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorShowFullClientInfoButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorShowFullClientInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorShowFullClientInfoButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorShowFullClientInfoButton.ForeColor = System.Drawing.Color.Black;
            this.operatorShowFullClientInfoButton.Location = new System.Drawing.Point(720, 48);
            this.operatorShowFullClientInfoButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorShowFullClientInfoButton.Name = "operatorShowFullClientInfoButton";
            this.operatorShowFullClientInfoButton.Size = new System.Drawing.Size(216, 144);
            this.operatorShowFullClientInfoButton.TabIndex = 20;
            this.operatorShowFullClientInfoButton.Text = "Подробная информация о клиенте";
            this.operatorShowFullClientInfoButton.UseVisualStyleBackColor = false;
            this.operatorShowFullClientInfoButton.Click += new System.EventHandler(this.operatorShowFullClientInfoButton_Click);
            // 
            // operatorClientsGrid
            // 
            this.operatorClientsGrid.AllowUserToAddRows = false;
            this.operatorClientsGrid.AllowUserToDeleteRows = false;
            this.operatorClientsGrid.AutoGenerateColumns = false;
            this.operatorClientsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.operatorClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.operatorClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDКлиентаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.городDataGridViewTextBoxColumn,
            this.доходDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.operatorClientsGrid.DataSource = this.получитьСписокКлиентовBindingSource;
            this.operatorClientsGrid.Location = new System.Drawing.Point(40, 16);
            this.operatorClientsGrid.Name = "operatorClientsGrid";
            this.operatorClientsGrid.ReadOnly = true;
            this.operatorClientsGrid.RowTemplate.Height = 24;
            this.operatorClientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.operatorClientsGrid.Size = new System.Drawing.Size(640, 385);
            this.operatorClientsGrid.TabIndex = 21;
            this.operatorClientsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operatorClientsGrid_MouseClick);
            // 
            // iDКлиентаDataGridViewTextBoxColumn
            // 
            this.iDКлиентаDataGridViewTextBoxColumn.DataPropertyName = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.HeaderText = "IDКлиента";
            this.iDКлиентаDataGridViewTextBoxColumn.Name = "iDКлиентаDataGridViewTextBoxColumn";
            this.iDКлиентаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDКлиентаDataGridViewTextBoxColumn.Width = 106;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 71;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.ReadOnly = true;
            this.городDataGridViewTextBoxColumn.Width = 77;
            // 
            // доходDataGridViewTextBoxColumn
            // 
            this.доходDataGridViewTextBoxColumn.DataPropertyName = "Доход";
            this.доходDataGridViewTextBoxColumn.HeaderText = "Доход";
            this.доходDataGridViewTextBoxColumn.Name = "доходDataGridViewTextBoxColumn";
            this.доходDataGridViewTextBoxColumn.ReadOnly = true;
            this.доходDataGridViewTextBoxColumn.Width = 78;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.ReadOnly = true;
            this.статусDataGridViewTextBoxColumn.Width = 82;
            // 
            // получитьСписокКлиентовBindingSource
            // 
            this.получитьСписокКлиентовBindingSource.DataMember = "ПолучитьСписокКлиентов";
            this.получитьСписокКлиентовBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorTabControl
            // 
            this.operatorTabControl.Controls.Add(this.operatorMainPage);
            this.operatorTabControl.Controls.Add(this.operatorClientsPage);
            this.operatorTabControl.Controls.Add(this.operatorPotentialClientsPage);
            this.operatorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operatorTabControl.Location = new System.Drawing.Point(0, 0);
            this.operatorTabControl.Name = "operatorTabControl";
            this.operatorTabControl.SelectedIndex = 0;
            this.operatorTabControl.Size = new System.Drawing.Size(982, 553);
            this.operatorTabControl.TabIndex = 0;
            // 
            // operatorMainPage
            // 
            this.operatorMainPage.BackColor = System.Drawing.Color.MintCream;
            this.operatorMainPage.Controls.Add(this.operatorShowPotentialClientsButton);
            this.operatorMainPage.Controls.Add(this.operatorShowClientsButton);
            this.operatorMainPage.Location = new System.Drawing.Point(4, 25);
            this.operatorMainPage.Name = "operatorMainPage";
            this.operatorMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.operatorMainPage.Size = new System.Drawing.Size(974, 524);
            this.operatorMainPage.TabIndex = 0;
            this.operatorMainPage.Text = "Главная страница";
            // 
            // operatorShowPotentialClientsButton
            // 
            this.operatorShowPotentialClientsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorShowPotentialClientsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorShowPotentialClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorShowPotentialClientsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorShowPotentialClientsButton.ForeColor = System.Drawing.Color.Black;
            this.operatorShowPotentialClientsButton.Location = new System.Drawing.Point(528, 184);
            this.operatorShowPotentialClientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorShowPotentialClientsButton.Name = "operatorShowPotentialClientsButton";
            this.operatorShowPotentialClientsButton.Size = new System.Drawing.Size(368, 120);
            this.operatorShowPotentialClientsButton.TabIndex = 8;
            this.operatorShowPotentialClientsButton.Text = "Потенциальные клиенты";
            this.operatorShowPotentialClientsButton.UseVisualStyleBackColor = false;
            this.operatorShowPotentialClientsButton.Click += new System.EventHandler(this.operatorShowPotentialClientsButton_Click);
            // 
            // operatorShowClientsButton
            // 
            this.operatorShowClientsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.operatorShowClientsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.operatorShowClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorShowClientsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operatorShowClientsButton.ForeColor = System.Drawing.Color.Black;
            this.operatorShowClientsButton.Location = new System.Drawing.Point(80, 184);
            this.operatorShowClientsButton.Margin = new System.Windows.Forms.Padding(4);
            this.operatorShowClientsButton.Name = "operatorShowClientsButton";
            this.operatorShowClientsButton.Size = new System.Drawing.Size(366, 120);
            this.operatorShowClientsButton.TabIndex = 7;
            this.operatorShowClientsButton.Text = "Клиенты";
            this.operatorShowClientsButton.UseVisualStyleBackColor = false;
            this.operatorShowClientsButton.Click += new System.EventHandler(this.operatorShowClientsButton_Click);
            // 
            // получитьСписокКлиентовTableAdapter
            // 
            this.получитьСписокКлиентовTableAdapter.ClearBeforeFill = true;
            // 
            // остутствующиеАктивныеСчетаTableAdapter
            // 
            this.остутствующиеАктивныеСчетаTableAdapter.ClearBeforeFill = true;
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.operatorTabControl);
            this.Name = "OperatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Банкир-оператор";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            this.operatorPotentialClientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operatorPotentialClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.остутствующиеАктивныеСчетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            this.operatorClientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operatorClientsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСписокКлиентовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            this.operatorTabControl.ResumeLayout(false);
            this.operatorMainPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage operatorPotentialClientsPage;
        private System.Windows.Forms.Button operatorGoToMainPageFromPotentialClientsPageButton;
        private System.Windows.Forms.TabPage operatorClientsPage;
        private System.Windows.Forms.Button operatorShowFullClientInfoButton;
        private System.Windows.Forms.DataGridView operatorClientsGrid;
        private System.Windows.Forms.Button operatorGoToMainPageFromClientsPageButton;
        private System.Windows.Forms.TabControl operatorTabControl;
        private System.Windows.Forms.TabPage operatorMainPage;
        private System.Windows.Forms.Button operatorShowPotentialClientsButton;
        private System.Windows.Forms.Button operatorShowClientsButton;
        private System.Windows.Forms.Button operatorOpenCardButton;
        private System.Windows.Forms.DataGridView operatorPotentialClientsGrid;
        private System.Windows.Forms.Button operatorOpenCreditRequestButton;
        private System.Windows.Forms.Button operatorOpenContributionButton;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.BindingSource получитьСписокКлиентовBindingSource;
        private BankDataSetTableAdapters.ПолучитьСписокКлиентовTableAdapter получитьСписокКлиентовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доходDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button operatorAddNewClientButton;
        private BankDataSet bankDataSet1;
        private System.Windows.Forms.BindingSource остутствующиеАктивныеСчетаBindingSource;
        private BankDataSetTableAdapters.ОстутствующиеАктивныеСчетаTableAdapter остутствующиеАктивныеСчетаTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDКлиентаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn отсутствующийАктивныйСчетDataGridViewTextBoxColumn;
    }
}