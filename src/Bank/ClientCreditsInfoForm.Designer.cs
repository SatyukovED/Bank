namespace Bank
{
    partial class ClientCreditsInfoForm
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
            this.clientInfoTabControl = new System.Windows.Forms.TabControl();
            this.clientMainPage = new System.Windows.Forms.TabPage();
            this.clientDebtExistenceTextBox = new System.Windows.Forms.TextBox();
            this.clientClosedCreditsNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientActiveCreditsNumberTextBox = new System.Windows.Forms.TextBox();
            this.clientStatusTextBox = new System.Windows.Forms.TextBox();
            this.clientIncomeTextBox = new System.Windows.Forms.TextBox();
            this.clientTownTextBox = new System.Windows.Forms.TextBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientActiveCreditsNumberLabel = new System.Windows.Forms.Label();
            this.clientDebtExistenceLabel = new System.Windows.Forms.Label();
            this.clientClosedCreditsNumberLabel = new System.Windows.Forms.Label();
            this.clientStatusLabel = new System.Windows.Forms.Label();
            this.clientIncomeLabel = new System.Windows.Forms.Label();
            this.clientTownLabel = new System.Windows.Forms.Label();
            this.clientNameLabel = new System.Windows.Forms.Label();
            this.clientIDTextBox = new System.Windows.Forms.TextBox();
            this.clientIDLabel = new System.Windows.Forms.Label();
            this.clientCreditsPage = new System.Windows.Forms.TabPage();
            this.clientCreditDebtAmountTextBox = new System.Windows.Forms.TextBox();
            this.clientCreditDebtAmountLabel = new System.Windows.Forms.Label();
            this.clientShowCreditOperationsButton = new System.Windows.Forms.Button();
            this.clientCreditsGrid = new System.Windows.Forms.DataGridView();
            this.номерКредитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаКредитаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процентDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОткрытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаЗакрытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокКредитовКлиентаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.clientCreditOperationsGrid = new System.Windows.Forms.DataGridView();
            this.способОплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерСчетаОтправителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОтделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОператораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПроведенияОперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.операцииПоСчетуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientHideCreditOperationsButton = new System.Windows.Forms.Button();
            this.списокКредитовКлиентаTableAdapter = new Bank.BankDataSetTableAdapters.СписокКредитовКлиентаTableAdapter();
            this.операцииПоСчетуTableAdapter = new Bank.BankDataSetTableAdapters.ОперацииПоСчетуTableAdapter();
            this.clientInfoTabControl.SuspendLayout();
            this.clientMainPage.SuspendLayout();
            this.clientCreditsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКредитовКлиентаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditOperationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииПоСчетуBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // clientInfoTabControl
            // 
            this.clientInfoTabControl.Controls.Add(this.clientMainPage);
            this.clientInfoTabControl.Controls.Add(this.clientCreditsPage);
            this.clientInfoTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientInfoTabControl.Location = new System.Drawing.Point(0, 0);
            this.clientInfoTabControl.Name = "clientInfoTabControl";
            this.clientInfoTabControl.SelectedIndex = 0;
            this.clientInfoTabControl.Size = new System.Drawing.Size(900, 503);
            this.clientInfoTabControl.TabIndex = 0;
            // 
            // clientMainPage
            // 
            this.clientMainPage.BackColor = System.Drawing.Color.MintCream;
            this.clientMainPage.Controls.Add(this.clientDebtExistenceTextBox);
            this.clientMainPage.Controls.Add(this.clientClosedCreditsNumberTextBox);
            this.clientMainPage.Controls.Add(this.clientActiveCreditsNumberTextBox);
            this.clientMainPage.Controls.Add(this.clientStatusTextBox);
            this.clientMainPage.Controls.Add(this.clientIncomeTextBox);
            this.clientMainPage.Controls.Add(this.clientTownTextBox);
            this.clientMainPage.Controls.Add(this.clientNameTextBox);
            this.clientMainPage.Controls.Add(this.clientActiveCreditsNumberLabel);
            this.clientMainPage.Controls.Add(this.clientDebtExistenceLabel);
            this.clientMainPage.Controls.Add(this.clientClosedCreditsNumberLabel);
            this.clientMainPage.Controls.Add(this.clientStatusLabel);
            this.clientMainPage.Controls.Add(this.clientIncomeLabel);
            this.clientMainPage.Controls.Add(this.clientTownLabel);
            this.clientMainPage.Controls.Add(this.clientNameLabel);
            this.clientMainPage.Controls.Add(this.clientIDTextBox);
            this.clientMainPage.Controls.Add(this.clientIDLabel);
            this.clientMainPage.Location = new System.Drawing.Point(4, 25);
            this.clientMainPage.Name = "clientMainPage";
            this.clientMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientMainPage.Size = new System.Drawing.Size(892, 474);
            this.clientMainPage.TabIndex = 0;
            this.clientMainPage.Text = "Основная информация";
            // 
            // clientDebtExistenceTextBox
            // 
            this.clientDebtExistenceTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientDebtExistenceTextBox.Location = new System.Drawing.Point(460, 416);
            this.clientDebtExistenceTextBox.Name = "clientDebtExistenceTextBox";
            this.clientDebtExistenceTextBox.ReadOnly = true;
            this.clientDebtExistenceTextBox.Size = new System.Drawing.Size(132, 40);
            this.clientDebtExistenceTextBox.TabIndex = 26;
            this.clientDebtExistenceTextBox.Visible = false;
            // 
            // clientClosedCreditsNumberTextBox
            // 
            this.clientClosedCreditsNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientClosedCreditsNumberTextBox.Location = new System.Drawing.Point(460, 304);
            this.clientClosedCreditsNumberTextBox.Name = "clientClosedCreditsNumberTextBox";
            this.clientClosedCreditsNumberTextBox.ReadOnly = true;
            this.clientClosedCreditsNumberTextBox.Size = new System.Drawing.Size(132, 40);
            this.clientClosedCreditsNumberTextBox.TabIndex = 25;
            // 
            // clientActiveCreditsNumberTextBox
            // 
            this.clientActiveCreditsNumberTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientActiveCreditsNumberTextBox.Location = new System.Drawing.Point(460, 360);
            this.clientActiveCreditsNumberTextBox.Name = "clientActiveCreditsNumberTextBox";
            this.clientActiveCreditsNumberTextBox.ReadOnly = true;
            this.clientActiveCreditsNumberTextBox.Size = new System.Drawing.Size(132, 40);
            this.clientActiveCreditsNumberTextBox.TabIndex = 24;
            // 
            // clientStatusTextBox
            // 
            this.clientStatusTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientStatusTextBox.Location = new System.Drawing.Point(460, 248);
            this.clientStatusTextBox.Name = "clientStatusTextBox";
            this.clientStatusTextBox.ReadOnly = true;
            this.clientStatusTextBox.Size = new System.Drawing.Size(212, 40);
            this.clientStatusTextBox.TabIndex = 23;
            // 
            // clientIncomeTextBox
            // 
            this.clientIncomeTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIncomeTextBox.Location = new System.Drawing.Point(460, 192);
            this.clientIncomeTextBox.Name = "clientIncomeTextBox";
            this.clientIncomeTextBox.ReadOnly = true;
            this.clientIncomeTextBox.Size = new System.Drawing.Size(212, 40);
            this.clientIncomeTextBox.TabIndex = 22;
            // 
            // clientTownTextBox
            // 
            this.clientTownTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientTownTextBox.Location = new System.Drawing.Point(460, 136);
            this.clientTownTextBox.Name = "clientTownTextBox";
            this.clientTownTextBox.ReadOnly = true;
            this.clientTownTextBox.Size = new System.Drawing.Size(412, 40);
            this.clientTownTextBox.TabIndex = 21;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientNameTextBox.Location = new System.Drawing.Point(460, 80);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.ReadOnly = true;
            this.clientNameTextBox.Size = new System.Drawing.Size(412, 40);
            this.clientNameTextBox.TabIndex = 20;
            // 
            // clientActiveCreditsNumberLabel
            // 
            this.clientActiveCreditsNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientActiveCreditsNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientActiveCreditsNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.clientActiveCreditsNumberLabel.Location = new System.Drawing.Point(-16, 360);
            this.clientActiveCreditsNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientActiveCreditsNumberLabel.Name = "clientActiveCreditsNumberLabel";
            this.clientActiveCreditsNumberLabel.Size = new System.Drawing.Size(448, 40);
            this.clientActiveCreditsNumberLabel.TabIndex = 19;
            this.clientActiveCreditsNumberLabel.Text = "Открытых кредитов";
            this.clientActiveCreditsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientDebtExistenceLabel
            // 
            this.clientDebtExistenceLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientDebtExistenceLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientDebtExistenceLabel.ForeColor = System.Drawing.Color.Black;
            this.clientDebtExistenceLabel.Location = new System.Drawing.Point(32, 416);
            this.clientDebtExistenceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientDebtExistenceLabel.Name = "clientDebtExistenceLabel";
            this.clientDebtExistenceLabel.Size = new System.Drawing.Size(392, 40);
            this.clientDebtExistenceLabel.TabIndex = 18;
            this.clientDebtExistenceLabel.Text = "Есть ли задолженности";
            this.clientDebtExistenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clientDebtExistenceLabel.Visible = false;
            // 
            // clientClosedCreditsNumberLabel
            // 
            this.clientClosedCreditsNumberLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientClosedCreditsNumberLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientClosedCreditsNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.clientClosedCreditsNumberLabel.Location = new System.Drawing.Point(-32, 304);
            this.clientClosedCreditsNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientClosedCreditsNumberLabel.Name = "clientClosedCreditsNumberLabel";
            this.clientClosedCreditsNumberLabel.Size = new System.Drawing.Size(464, 40);
            this.clientClosedCreditsNumberLabel.TabIndex = 16;
            this.clientClosedCreditsNumberLabel.Text = "Закрытых кредитов";
            this.clientClosedCreditsNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientStatusLabel
            // 
            this.clientStatusLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientStatusLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.clientStatusLabel.Location = new System.Drawing.Point(256, 248);
            this.clientStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientStatusLabel.Name = "clientStatusLabel";
            this.clientStatusLabel.Size = new System.Drawing.Size(176, 40);
            this.clientStatusLabel.TabIndex = 15;
            this.clientStatusLabel.Text = "Статус";
            this.clientStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientIncomeLabel
            // 
            this.clientIncomeLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientIncomeLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientIncomeLabel.ForeColor = System.Drawing.Color.Black;
            this.clientIncomeLabel.Location = new System.Drawing.Point(256, 192);
            this.clientIncomeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientIncomeLabel.Name = "clientIncomeLabel";
            this.clientIncomeLabel.Size = new System.Drawing.Size(176, 40);
            this.clientIncomeLabel.TabIndex = 14;
            this.clientIncomeLabel.Text = "Доход";
            this.clientIncomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientTownLabel
            // 
            this.clientTownLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientTownLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientTownLabel.ForeColor = System.Drawing.Color.Black;
            this.clientTownLabel.Location = new System.Drawing.Point(256, 136);
            this.clientTownLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientTownLabel.Name = "clientTownLabel";
            this.clientTownLabel.Size = new System.Drawing.Size(176, 40);
            this.clientTownLabel.TabIndex = 13;
            this.clientTownLabel.Text = "Город";
            this.clientTownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientNameLabel
            // 
            this.clientNameLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientNameLabel.ForeColor = System.Drawing.Color.Black;
            this.clientNameLabel.Location = new System.Drawing.Point(256, 80);
            this.clientNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientNameLabel.Name = "clientNameLabel";
            this.clientNameLabel.Size = new System.Drawing.Size(176, 40);
            this.clientNameLabel.TabIndex = 12;
            this.clientNameLabel.Text = "ФИО";
            this.clientNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientIDTextBox
            // 
            this.clientIDTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientIDTextBox.Location = new System.Drawing.Point(460, 24);
            this.clientIDTextBox.Name = "clientIDTextBox";
            this.clientIDTextBox.ReadOnly = true;
            this.clientIDTextBox.Size = new System.Drawing.Size(132, 40);
            this.clientIDTextBox.TabIndex = 11;
            // 
            // clientIDLabel
            // 
            this.clientIDLabel.BackColor = System.Drawing.Color.MintCream;
            this.clientIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 14.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.clientIDLabel.ForeColor = System.Drawing.Color.Black;
            this.clientIDLabel.Location = new System.Drawing.Point(256, 24);
            this.clientIDLabel.Margin = new System.Windows.Forms.Padding(0);
            this.clientIDLabel.Name = "clientIDLabel";
            this.clientIDLabel.Size = new System.Drawing.Size(176, 40);
            this.clientIDLabel.TabIndex = 10;
            this.clientIDLabel.Text = "ID";
            this.clientIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientCreditsPage
            // 
            this.clientCreditsPage.BackColor = System.Drawing.Color.MintCream;
            this.clientCreditsPage.Controls.Add(this.clientCreditDebtAmountTextBox);
            this.clientCreditsPage.Controls.Add(this.clientCreditDebtAmountLabel);
            this.clientCreditsPage.Controls.Add(this.clientCreditsGrid);
            this.clientCreditsPage.Controls.Add(this.clientCreditOperationsGrid);
            this.clientCreditsPage.Controls.Add(this.clientHideCreditOperationsButton);
            this.clientCreditsPage.Controls.Add(this.clientShowCreditOperationsButton);
            this.clientCreditsPage.Location = new System.Drawing.Point(4, 25);
            this.clientCreditsPage.Name = "clientCreditsPage";
            this.clientCreditsPage.Padding = new System.Windows.Forms.Padding(3);
            this.clientCreditsPage.Size = new System.Drawing.Size(892, 474);
            this.clientCreditsPage.TabIndex = 1;
            this.clientCreditsPage.Text = "Кредиты";
            // 
            // clientCreditDebtAmountTextBox
            // 
            this.clientCreditDebtAmountTextBox.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientCreditDebtAmountTextBox.Location = new System.Drawing.Point(628, 392);
            this.clientCreditDebtAmountTextBox.Name = "clientCreditDebtAmountTextBox";
            this.clientCreditDebtAmountTextBox.ReadOnly = true;
            this.clientCreditDebtAmountTextBox.Size = new System.Drawing.Size(240, 40);
            this.clientCreditDebtAmountTextBox.TabIndex = 24;
            this.clientCreditDebtAmountTextBox.Visible = false;
            // 
            // clientCreditDebtAmountLabel
            // 
            this.clientCreditDebtAmountLabel.AutoSize = true;
            this.clientCreditDebtAmountLabel.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clientCreditDebtAmountLabel.Location = new System.Drawing.Point(408, 396);
            this.clientCreditDebtAmountLabel.Name = "clientCreditDebtAmountLabel";
            this.clientCreditDebtAmountLabel.Size = new System.Drawing.Size(189, 33);
            this.clientCreditDebtAmountLabel.TabIndex = 23;
            this.clientCreditDebtAmountLabel.Text = "Задолженность";
            this.clientCreditDebtAmountLabel.Visible = false;
            // 
            // clientShowCreditOperationsButton
            // 
            this.clientShowCreditOperationsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clientShowCreditOperationsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.clientShowCreditOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientShowCreditOperationsButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.clientShowCreditOperationsButton.ForeColor = System.Drawing.Color.Black;
            this.clientShowCreditOperationsButton.Location = new System.Drawing.Point(24, 368);
            this.clientShowCreditOperationsButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientShowCreditOperationsButton.Name = "clientShowCreditOperationsButton";
            this.clientShowCreditOperationsButton.Size = new System.Drawing.Size(272, 96);
            this.clientShowCreditOperationsButton.TabIndex = 11;
            this.clientShowCreditOperationsButton.Text = "Список операций по кредиту";
            this.clientShowCreditOperationsButton.UseVisualStyleBackColor = false;
            this.clientShowCreditOperationsButton.Click += new System.EventHandler(this.clientShowCreditOperationsButton_Click);
            // 
            // clientCreditsGrid
            // 
            this.clientCreditsGrid.AllowUserToAddRows = false;
            this.clientCreditsGrid.AllowUserToDeleteRows = false;
            this.clientCreditsGrid.AutoGenerateColumns = false;
            this.clientCreditsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientCreditsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientCreditsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерКредитаDataGridViewTextBoxColumn,
            this.суммаКредитаDataGridViewTextBoxColumn,
            this.процентDataGridViewTextBoxColumn,
            this.датаОткрытияDataGridViewTextBoxColumn,
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn,
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn,
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn,
            this.датаЗакрытияDataGridViewTextBoxColumn});
            this.clientCreditsGrid.DataSource = this.списокКредитовКлиентаBindingSource;
            this.clientCreditsGrid.Location = new System.Drawing.Point(24, 16);
            this.clientCreditsGrid.Name = "clientCreditsGrid";
            this.clientCreditsGrid.ReadOnly = true;
            this.clientCreditsGrid.RowTemplate.Height = 24;
            this.clientCreditsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientCreditsGrid.Size = new System.Drawing.Size(845, 336);
            this.clientCreditsGrid.TabIndex = 21;
            this.clientCreditsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientCreditsGrid_MouseClick);
            // 
            // номерКредитаDataGridViewTextBoxColumn
            // 
            this.номерКредитаDataGridViewTextBoxColumn.DataPropertyName = "НомерКредита";
            this.номерКредитаDataGridViewTextBoxColumn.HeaderText = "Номер кредита";
            this.номерКредитаDataGridViewTextBoxColumn.Name = "номерКредитаDataGridViewTextBoxColumn";
            this.номерКредитаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерКредитаDataGridViewTextBoxColumn.Width = 127;
            // 
            // суммаКредитаDataGridViewTextBoxColumn
            // 
            this.суммаКредитаDataGridViewTextBoxColumn.DataPropertyName = "СуммаКредита";
            this.суммаКредитаDataGridViewTextBoxColumn.HeaderText = "Сумма кредита";
            this.суммаКредитаDataGridViewTextBoxColumn.Name = "суммаКредитаDataGridViewTextBoxColumn";
            this.суммаКредитаDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаКредитаDataGridViewTextBoxColumn.Width = 126;
            // 
            // процентDataGridViewTextBoxColumn
            // 
            this.процентDataGridViewTextBoxColumn.DataPropertyName = "Процент";
            this.процентDataGridViewTextBoxColumn.HeaderText = "Процент";
            this.процентDataGridViewTextBoxColumn.Name = "процентDataGridViewTextBoxColumn";
            this.процентDataGridViewTextBoxColumn.ReadOnly = true;
            this.процентDataGridViewTextBoxColumn.Width = 94;
            // 
            // датаОткрытияDataGridViewTextBoxColumn
            // 
            this.датаОткрытияDataGridViewTextBoxColumn.DataPropertyName = "ДатаОткрытия";
            this.датаОткрытияDataGridViewTextBoxColumn.HeaderText = "Дата открытия";
            this.датаОткрытияDataGridViewTextBoxColumn.Name = "датаОткрытияDataGridViewTextBoxColumn";
            this.датаОткрытияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаОткрытияDataGridViewTextBoxColumn.Width = 127;
            // 
            // срокКредитаВМесяцахDataGridViewTextBoxColumn
            // 
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.DataPropertyName = "СрокКредитаВМесяцах";
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.HeaderText = "Срок кредита в месяцах";
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.Name = "срокКредитаВМесяцахDataGridViewTextBoxColumn";
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.ReadOnly = true;
            this.срокКредитаВМесяцахDataGridViewTextBoxColumn.Width = 130;
            // 
            // суммаКредитаСПроцентамиDataGridViewTextBoxColumn
            // 
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn.DataPropertyName = "СуммаКредитаСПроцентами";
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn.HeaderText = "Сумма кредита с процентами";
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn.Name = "суммаКредитаСПроцентамиDataGridViewTextBoxColumn";
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаКредитаСПроцентамиDataGridViewTextBoxColumn.Width = 139;
            // 
            // суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn
            // 
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn.DataPropertyName = "СуммаЕжемесячнойВыплаты";
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn.HeaderText = "Сумма ежемесячной выплаты";
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn.Name = "суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn";
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn.Width = 213;
            // 
            // датаЗакрытияDataGridViewTextBoxColumn
            // 
            this.датаЗакрытияDataGridViewTextBoxColumn.DataPropertyName = "ДатаЗакрытия";
            this.датаЗакрытияDataGridViewTextBoxColumn.HeaderText = "Дата закрытия";
            this.датаЗакрытияDataGridViewTextBoxColumn.Name = "датаЗакрытияDataGridViewTextBoxColumn";
            this.датаЗакрытияDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаЗакрытияDataGridViewTextBoxColumn.Width = 127;
            // 
            // списокКредитовКлиентаBindingSource
            // 
            this.списокКредитовКлиентаBindingSource.DataMember = "СписокКредитовКлиента";
            this.списокКредитовКлиентаBindingSource.DataSource = this.bankDataSet;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientCreditOperationsGrid
            // 
            this.clientCreditOperationsGrid.AllowUserToAddRows = false;
            this.clientCreditOperationsGrid.AllowUserToDeleteRows = false;
            this.clientCreditOperationsGrid.AutoGenerateColumns = false;
            this.clientCreditOperationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientCreditOperationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientCreditOperationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.способОплатыDataGridViewTextBoxColumn,
            this.номерСчетаОтправителяDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn,
            this.iDОтделенияDataGridViewTextBoxColumn,
            this.iDОператораDataGridViewTextBoxColumn,
            this.датаПроведенияОперацииDataGridViewTextBoxColumn});
            this.clientCreditOperationsGrid.DataSource = this.операцииПоСчетуBindingSource;
            this.clientCreditOperationsGrid.Location = new System.Drawing.Point(24, 16);
            this.clientCreditOperationsGrid.Name = "clientCreditOperationsGrid";
            this.clientCreditOperationsGrid.ReadOnly = true;
            this.clientCreditOperationsGrid.RowTemplate.Height = 24;
            this.clientCreditOperationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientCreditOperationsGrid.Size = new System.Drawing.Size(845, 336);
            this.clientCreditOperationsGrid.TabIndex = 22;
            this.clientCreditOperationsGrid.Visible = false;
            // 
            // способОплатыDataGridViewTextBoxColumn
            // 
            this.способОплатыDataGridViewTextBoxColumn.DataPropertyName = "Способ оплаты";
            this.способОплатыDataGridViewTextBoxColumn.HeaderText = "Способ оплаты";
            this.способОплатыDataGridViewTextBoxColumn.Name = "способОплатыDataGridViewTextBoxColumn";
            this.способОплатыDataGridViewTextBoxColumn.ReadOnly = true;
            this.способОплатыDataGridViewTextBoxColumn.Width = 127;
            // 
            // номерСчетаОтправителяDataGridViewTextBoxColumn
            // 
            this.номерСчетаОтправителяDataGridViewTextBoxColumn.DataPropertyName = "НомерСчетаОтправителя";
            this.номерСчетаОтправителяDataGridViewTextBoxColumn.HeaderText = "Номер счета оплаты";
            this.номерСчетаОтправителяDataGridViewTextBoxColumn.Name = "номерСчетаОтправителяDataGridViewTextBoxColumn";
            this.номерСчетаОтправителяDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерСчетаОтправителяDataGridViewTextBoxColumn.Width = 160;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаDataGridViewTextBoxColumn.Width = 79;
            // 
            // iDОтделенияDataGridViewTextBoxColumn
            // 
            this.iDОтделенияDataGridViewTextBoxColumn.DataPropertyName = "IDОтделения";
            this.iDОтделенияDataGridViewTextBoxColumn.HeaderText = "IDОтделения";
            this.iDОтделенияDataGridViewTextBoxColumn.Name = "iDОтделенияDataGridViewTextBoxColumn";
            this.iDОтделенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDОтделенияDataGridViewTextBoxColumn.Width = 124;
            // 
            // iDОператораDataGridViewTextBoxColumn
            // 
            this.iDОператораDataGridViewTextBoxColumn.DataPropertyName = "IDОператора";
            this.iDОператораDataGridViewTextBoxColumn.HeaderText = "IDОператора";
            this.iDОператораDataGridViewTextBoxColumn.Name = "iDОператораDataGridViewTextBoxColumn";
            this.iDОператораDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDОператораDataGridViewTextBoxColumn.Width = 124;
            // 
            // датаПроведенияОперацииDataGridViewTextBoxColumn
            // 
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.DataPropertyName = "ДатаПроведенияОперации";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.HeaderText = "Дата проведения операции";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.Name = "датаПроведенияОперацииDataGridViewTextBoxColumn";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.Width = 202;
            // 
            // операцииПоСчетуBindingSource
            // 
            this.операцииПоСчетуBindingSource.DataMember = "ОперацииПоСчету";
            this.операцииПоСчетуBindingSource.DataSource = this.bankDataSet;
            // 
            // clientHideCreditOperationsButton
            // 
            this.clientHideCreditOperationsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.clientHideCreditOperationsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.clientHideCreditOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientHideCreditOperationsButton.Font = new System.Drawing.Font("Comic Sans MS", 14.8F, System.Drawing.FontStyle.Bold);
            this.clientHideCreditOperationsButton.ForeColor = System.Drawing.Color.Black;
            this.clientHideCreditOperationsButton.Location = new System.Drawing.Point(24, 368);
            this.clientHideCreditOperationsButton.Margin = new System.Windows.Forms.Padding(4);
            this.clientHideCreditOperationsButton.Name = "clientHideCreditOperationsButton";
            this.clientHideCreditOperationsButton.Size = new System.Drawing.Size(272, 96);
            this.clientHideCreditOperationsButton.TabIndex = 12;
            this.clientHideCreditOperationsButton.Text = "Скрыть список операций";
            this.clientHideCreditOperationsButton.UseVisualStyleBackColor = false;
            this.clientHideCreditOperationsButton.Visible = false;
            this.clientHideCreditOperationsButton.Click += new System.EventHandler(this.clientHideCreditOperationsButton_Click);
            // 
            // списокКредитовКлиентаTableAdapter
            // 
            this.списокКредитовКлиентаTableAdapter.ClearBeforeFill = true;
            // 
            // операцииПоСчетуTableAdapter
            // 
            this.операцииПоСчетуTableAdapter.ClearBeforeFill = true;
            // 
            // ClientCreditsInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(900, 503);
            this.Controls.Add(this.clientInfoTabControl);
            this.Name = "ClientCreditsInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о клиенте";
            this.Load += new System.EventHandler(this.ClientCreditsInfoForm_Load);
            this.clientInfoTabControl.ResumeLayout(false);
            this.clientMainPage.ResumeLayout(false);
            this.clientMainPage.PerformLayout();
            this.clientCreditsPage.ResumeLayout(false);
            this.clientCreditsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокКредитовКлиентаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCreditOperationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.операцииПоСчетуBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl clientInfoTabControl;
        private System.Windows.Forms.TabPage clientMainPage;
        private System.Windows.Forms.TabPage clientCreditsPage;
        private System.Windows.Forms.TextBox clientDebtExistenceTextBox;
        private System.Windows.Forms.TextBox clientClosedCreditsNumberTextBox;
        private System.Windows.Forms.TextBox clientActiveCreditsNumberTextBox;
        private System.Windows.Forms.TextBox clientStatusTextBox;
        private System.Windows.Forms.TextBox clientIncomeTextBox;
        private System.Windows.Forms.TextBox clientTownTextBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.Label clientActiveCreditsNumberLabel;
        private System.Windows.Forms.Label clientDebtExistenceLabel;
        private System.Windows.Forms.Label clientClosedCreditsNumberLabel;
        private System.Windows.Forms.Label clientStatusLabel;
        private System.Windows.Forms.Label clientIncomeLabel;
        private System.Windows.Forms.Label clientTownLabel;
        private System.Windows.Forms.Label clientNameLabel;
        private System.Windows.Forms.TextBox clientIDTextBox;
        private System.Windows.Forms.Label clientIDLabel;
        private System.Windows.Forms.Button clientHideCreditOperationsButton;
        private System.Windows.Forms.Button clientShowCreditOperationsButton;
        private System.Windows.Forms.DataGridView clientCreditsGrid;
        private System.Windows.Forms.DataGridView clientCreditOperationsGrid;
        private System.Windows.Forms.BindingSource списокКредитовКлиентаBindingSource;
        private BankDataSet bankDataSet;
        private BankDataSetTableAdapters.СписокКредитовКлиентаTableAdapter списокКредитовКлиентаTableAdapter;
        private System.Windows.Forms.BindingSource операцииПоСчетуBindingSource;
        private BankDataSetTableAdapters.ОперацииПоСчетуTableAdapter операцииПоСчетуTableAdapter;
        private System.Windows.Forms.TextBox clientCreditDebtAmountTextBox;
        private System.Windows.Forms.Label clientCreditDebtAmountLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn способОплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерСчетаОтправителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОтделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОператораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПроведенияОперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКредитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаКредитаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процентDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОткрытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокКредитаВМесяцахDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаКредитаСПроцентамиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаЕжемесячнойВыплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаЗакрытияDataGridViewTextBoxColumn;
    }
}