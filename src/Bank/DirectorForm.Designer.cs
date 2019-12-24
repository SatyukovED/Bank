namespace Bank
{
    partial class DirectorForm
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
            this.directorTabControl = new System.Windows.Forms.TabControl();
            this.directorMainPage = new System.Windows.Forms.TabPage();
            this.directorShowStatisticsButton = new System.Windows.Forms.Button();
            this.directorShowWorkersButton = new System.Windows.Forms.Button();
            this.directorShowDepartmentsButton = new System.Windows.Forms.Button();
            this.directorDepartmentsPage = new System.Windows.Forms.TabPage();
            this.directorMoveDepartmentButton = new System.Windows.Forms.Button();
            this.directorAddNewDepartmentButton = new System.Windows.Forms.Button();
            this.directorCloseDepartmentButton = new System.Windows.Forms.Button();
            this.directorGoToMainPageFromDepartmentsPageButton = new System.Windows.Forms.Button();
            this.directorDepartmentWorkersGrid = new System.Windows.Forms.DataGridView();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.получитьСписокСотрудниковОтделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet = new Bank.BankDataSet();
            this.directorDepartmentOperationsGrid = new System.Windows.Forms.DataGridView();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПроведенияОперацииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОператораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.получитьОперацииОтделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorDepartmentsGrid = new System.Windows.Forms.DataGridView();
            this.iDОтделенияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.городDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отделенияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorShowDepartmentWorkersButton = new System.Windows.Forms.Button();
            this.directorShowDepartmentOperationsButton = new System.Windows.Forms.Button();
            this.directorHideDepartmentWorkersButton = new System.Windows.Forms.Button();
            this.directorHideDepartmentOperationsButton = new System.Windows.Forms.Button();
            this.directorWorkersPage = new System.Windows.Forms.TabPage();
            this.directorActionsLabel = new System.Windows.Forms.Label();
            this.directorActionsComboBox = new System.Windows.Forms.ComboBox();
            this.directorGoToMainPageFromWorkersPageButton = new System.Windows.Forms.Button();
            this.directorWorkerCreditRequestsGrid = new System.Windows.Forms.DataGridView();
            this.directorWorkerOperationsGrid = new System.Windows.Forms.DataGridView();
            this.суммаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.получитьОперацииПоСотрудникуBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorWorkersGrid = new System.Windows.Forms.DataGridView();
            this.iDСотрудникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОтделенияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.должностьDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.зарплатаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.получитьСписокСотрудниковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorHideWorkerCreditRequestsButton = new System.Windows.Forms.Button();
            this.directorHideWorkerOperationsButton = new System.Windows.Forms.Button();
            this.directorExecuteActionButton = new System.Windows.Forms.Button();
            this.directorStatsPage = new System.Windows.Forms.TabPage();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.directorShowStatisticsGridButton = new System.Windows.Forms.Button();
            this.directorStatisticsDescriptionLabel = new System.Windows.Forms.Label();
            this.directorStatisticsLabel = new System.Windows.Forms.Label();
            this.directorStatisticsDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.directorStatisticsComboBox = new System.Windows.Forms.ComboBox();
            this.directorGoToMainPageFromStatisticsPageButton = new System.Windows.Forms.Button();
            this.directorStatisticsGrid = new System.Windows.Forms.DataGridView();
            this.получитьСписокСотрудниковОтделенияTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьСписокСотрудниковОтделенияTableAdapter();
            this.получитьОперацииОтделенияTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьОперацииОтделенияTableAdapter();
            this.выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter = new Bank.BankDataSetTableAdapters.ВыбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter();
            this.получитьОперацииПоСотрудникуTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьОперацииПоСотрудникуTableAdapter();
            this.отделенияTableAdapter = new Bank.BankDataSetTableAdapters.ОтделенияTableAdapter();
            this.получитьСписокСотрудниковTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьСписокСотрудниковTableAdapter();
            this.получитьЗаявкиНаКредитКредитораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьЗаявкиНаКредитКредитораTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьЗаявкиНаКредитКредитораTableAdapter();
            this.получитьЗаявкиНаКредитОператораBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьЗаявкиНаКредитОператораTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьЗаявкиНаКредитОператораTableAdapter();
            this.bankDataSet1 = new Bank.BankDataSet();
            this.найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.найтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter = new Bank.BankDataSetTableAdapters.НайтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter();
            this.найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.найтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter = new Bank.BankDataSetTableAdapters.НайтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter();
            this.найтиКредитораНеОдобрившегоНиОдинКредитBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.найтиКредитораНеОдобрившегоНиОдинКредитTableAdapter = new Bank.BankDataSetTableAdapters.НайтиКредитораНеОдобрившегоНиОдинКредитTableAdapter();
            this.рассчитатьКоличествоКлиентовПоГородамBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.рассчитатьКоличествоКлиентовПоГородамTableAdapter = new Bank.BankDataSetTableAdapters.РассчитатьКоличествоКлиентовПоГородамTableAdapter();
            this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter = new Bank.BankDataSetTableAdapters.ВыбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter();
            this.получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.получитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter = new Bank.BankDataSetTableAdapters.ПолучитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter();
            this.directorTabControl.SuspendLayout();
            this.directorMainPage.SuspendLayout();
            this.directorDepartmentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorDepartmentWorkersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСписокСотрудниковОтделенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorDepartmentOperationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьОперацииОтделенияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorDepartmentsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделенияBindingSource)).BeginInit();
            this.directorWorkersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorWorkerCreditRequestsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorWorkerOperationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьОперацииПоСотрудникуBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorWorkersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСписокСотрудниковBindingSource)).BeginInit();
            this.directorStatsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorStatisticsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьЗаявкиНаКредитКредитораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьЗаявкиНаКредитОператораBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.найтиКредитораНеОдобрившегоНиОдинКредитBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.рассчитатьКоличествоКлиентовПоГородамBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // directorTabControl
            // 
            this.directorTabControl.Controls.Add(this.directorMainPage);
            this.directorTabControl.Controls.Add(this.directorDepartmentsPage);
            this.directorTabControl.Controls.Add(this.directorWorkersPage);
            this.directorTabControl.Controls.Add(this.directorStatsPage);
            this.directorTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directorTabControl.Location = new System.Drawing.Point(0, 0);
            this.directorTabControl.Name = "directorTabControl";
            this.directorTabControl.SelectedIndex = 0;
            this.directorTabControl.Size = new System.Drawing.Size(982, 553);
            this.directorTabControl.TabIndex = 2;
            // 
            // directorMainPage
            // 
            this.directorMainPage.BackColor = System.Drawing.Color.MintCream;
            this.directorMainPage.Controls.Add(this.directorShowStatisticsButton);
            this.directorMainPage.Controls.Add(this.directorShowWorkersButton);
            this.directorMainPage.Controls.Add(this.directorShowDepartmentsButton);
            this.directorMainPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.directorMainPage.Location = new System.Drawing.Point(4, 25);
            this.directorMainPage.Name = "directorMainPage";
            this.directorMainPage.Padding = new System.Windows.Forms.Padding(3);
            this.directorMainPage.Size = new System.Drawing.Size(974, 524);
            this.directorMainPage.TabIndex = 0;
            this.directorMainPage.Text = "Главная страница";
            // 
            // directorShowStatisticsButton
            // 
            this.directorShowStatisticsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorShowStatisticsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorShowStatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorShowStatisticsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorShowStatisticsButton.ForeColor = System.Drawing.Color.Black;
            this.directorShowStatisticsButton.Location = new System.Drawing.Point(312, 304);
            this.directorShowStatisticsButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorShowStatisticsButton.Name = "directorShowStatisticsButton";
            this.directorShowStatisticsButton.Size = new System.Drawing.Size(350, 120);
            this.directorShowStatisticsButton.TabIndex = 3;
            this.directorShowStatisticsButton.Text = "Статистика";
            this.directorShowStatisticsButton.UseVisualStyleBackColor = false;
            this.directorShowStatisticsButton.Click += new System.EventHandler(this.directorShowStatisticsButton_Click);
            // 
            // directorShowWorkersButton
            // 
            this.directorShowWorkersButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorShowWorkersButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorShowWorkersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorShowWorkersButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorShowWorkersButton.ForeColor = System.Drawing.Color.Black;
            this.directorShowWorkersButton.Location = new System.Drawing.Point(544, 112);
            this.directorShowWorkersButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorShowWorkersButton.Name = "directorShowWorkersButton";
            this.directorShowWorkersButton.Size = new System.Drawing.Size(350, 120);
            this.directorShowWorkersButton.TabIndex = 2;
            this.directorShowWorkersButton.Text = "Список сотрудников";
            this.directorShowWorkersButton.UseVisualStyleBackColor = false;
            this.directorShowWorkersButton.Click += new System.EventHandler(this.directorShowWorkersButton_Click);
            // 
            // directorShowDepartmentsButton
            // 
            this.directorShowDepartmentsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorShowDepartmentsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorShowDepartmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorShowDepartmentsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorShowDepartmentsButton.ForeColor = System.Drawing.Color.Black;
            this.directorShowDepartmentsButton.Location = new System.Drawing.Point(80, 112);
            this.directorShowDepartmentsButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorShowDepartmentsButton.Name = "directorShowDepartmentsButton";
            this.directorShowDepartmentsButton.Size = new System.Drawing.Size(350, 120);
            this.directorShowDepartmentsButton.TabIndex = 1;
            this.directorShowDepartmentsButton.Text = "Список отделений";
            this.directorShowDepartmentsButton.UseVisualStyleBackColor = false;
            this.directorShowDepartmentsButton.Click += new System.EventHandler(this.directorShowDepartmentsButton_Click);
            // 
            // directorDepartmentsPage
            // 
            this.directorDepartmentsPage.BackColor = System.Drawing.Color.MintCream;
            this.directorDepartmentsPage.Controls.Add(this.directorMoveDepartmentButton);
            this.directorDepartmentsPage.Controls.Add(this.directorAddNewDepartmentButton);
            this.directorDepartmentsPage.Controls.Add(this.directorCloseDepartmentButton);
            this.directorDepartmentsPage.Controls.Add(this.directorGoToMainPageFromDepartmentsPageButton);
            this.directorDepartmentsPage.Controls.Add(this.directorDepartmentOperationsGrid);
            this.directorDepartmentsPage.Controls.Add(this.directorDepartmentsGrid);
            this.directorDepartmentsPage.Controls.Add(this.directorShowDepartmentWorkersButton);
            this.directorDepartmentsPage.Controls.Add(this.directorShowDepartmentOperationsButton);
            this.directorDepartmentsPage.Controls.Add(this.directorHideDepartmentWorkersButton);
            this.directorDepartmentsPage.Controls.Add(this.directorHideDepartmentOperationsButton);
            this.directorDepartmentsPage.Controls.Add(this.directorDepartmentWorkersGrid);
            this.directorDepartmentsPage.Location = new System.Drawing.Point(4, 25);
            this.directorDepartmentsPage.Name = "directorDepartmentsPage";
            this.directorDepartmentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.directorDepartmentsPage.Size = new System.Drawing.Size(974, 524);
            this.directorDepartmentsPage.TabIndex = 1;
            this.directorDepartmentsPage.Text = "Отделения";
            // 
            // directorMoveDepartmentButton
            // 
            this.directorMoveDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorMoveDepartmentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorMoveDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorMoveDepartmentButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorMoveDepartmentButton.ForeColor = System.Drawing.Color.Black;
            this.directorMoveDepartmentButton.Location = new System.Drawing.Point(480, 296);
            this.directorMoveDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorMoveDepartmentButton.Name = "directorMoveDepartmentButton";
            this.directorMoveDepartmentButton.Size = new System.Drawing.Size(472, 90);
            this.directorMoveDepartmentButton.TabIndex = 11;
            this.directorMoveDepartmentButton.Text = "Переместить отделение в другой город";
            this.directorMoveDepartmentButton.UseVisualStyleBackColor = false;
            this.directorMoveDepartmentButton.Click += new System.EventHandler(this.directorMoveDepartmentButton_Click);
            // 
            // directorAddNewDepartmentButton
            // 
            this.directorAddNewDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorAddNewDepartmentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorAddNewDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorAddNewDepartmentButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorAddNewDepartmentButton.ForeColor = System.Drawing.Color.Black;
            this.directorAddNewDepartmentButton.Location = new System.Drawing.Point(480, 408);
            this.directorAddNewDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorAddNewDepartmentButton.Name = "directorAddNewDepartmentButton";
            this.directorAddNewDepartmentButton.Size = new System.Drawing.Size(472, 90);
            this.directorAddNewDepartmentButton.TabIndex = 9;
            this.directorAddNewDepartmentButton.Text = "Открыть новое отделение";
            this.directorAddNewDepartmentButton.UseVisualStyleBackColor = false;
            this.directorAddNewDepartmentButton.Click += new System.EventHandler(this.directorAddNewDepartmentButton_Click);
            // 
            // directorCloseDepartmentButton
            // 
            this.directorCloseDepartmentButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorCloseDepartmentButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorCloseDepartmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorCloseDepartmentButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorCloseDepartmentButton.ForeColor = System.Drawing.Color.Black;
            this.directorCloseDepartmentButton.Location = new System.Drawing.Point(480, 184);
            this.directorCloseDepartmentButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorCloseDepartmentButton.Name = "directorCloseDepartmentButton";
            this.directorCloseDepartmentButton.Size = new System.Drawing.Size(472, 90);
            this.directorCloseDepartmentButton.TabIndex = 6;
            this.directorCloseDepartmentButton.Text = "Закрыть отделение";
            this.directorCloseDepartmentButton.UseVisualStyleBackColor = false;
            this.directorCloseDepartmentButton.Click += new System.EventHandler(this.directorCloseDepartmentButton_Click);
            // 
            // directorGoToMainPageFromDepartmentsPageButton
            // 
            this.directorGoToMainPageFromDepartmentsPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorGoToMainPageFromDepartmentsPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorGoToMainPageFromDepartmentsPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorGoToMainPageFromDepartmentsPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorGoToMainPageFromDepartmentsPageButton.ForeColor = System.Drawing.Color.Black;
            this.directorGoToMainPageFromDepartmentsPageButton.Location = new System.Drawing.Point(20, 420);
            this.directorGoToMainPageFromDepartmentsPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorGoToMainPageFromDepartmentsPageButton.Name = "directorGoToMainPageFromDepartmentsPageButton";
            this.directorGoToMainPageFromDepartmentsPageButton.Size = new System.Drawing.Size(222, 80);
            this.directorGoToMainPageFromDepartmentsPageButton.TabIndex = 1;
            this.directorGoToMainPageFromDepartmentsPageButton.Text = "На главную";
            this.directorGoToMainPageFromDepartmentsPageButton.UseVisualStyleBackColor = false;
            this.directorGoToMainPageFromDepartmentsPageButton.Click += new System.EventHandler(this.directorGoToMainPageFromDepartmentsPageButton_Click);
            // 
            // directorDepartmentWorkersGrid
            // 
            this.directorDepartmentWorkersGrid.AllowUserToAddRows = false;
            this.directorDepartmentWorkersGrid.AllowUserToDeleteRows = false;
            this.directorDepartmentWorkersGrid.AutoGenerateColumns = false;
            this.directorDepartmentWorkersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorDepartmentWorkersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorDepartmentWorkersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фИОDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn,
            this.зарплатаDataGridViewTextBoxColumn});
            this.directorDepartmentWorkersGrid.DataSource = this.получитьСписокСотрудниковОтделенияBindingSource;
            this.directorDepartmentWorkersGrid.Location = new System.Drawing.Point(24, 16);
            this.directorDepartmentWorkersGrid.Name = "directorDepartmentWorkersGrid";
            this.directorDepartmentWorkersGrid.ReadOnly = true;
            this.directorDepartmentWorkersGrid.RowTemplate.Height = 24;
            this.directorDepartmentWorkersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorDepartmentWorkersGrid.Size = new System.Drawing.Size(584, 385);
            this.directorDepartmentWorkersGrid.TabIndex = 7;
            this.directorDepartmentWorkersGrid.Visible = false;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn.Width = 71;
            // 
            // должностьDataGridViewTextBoxColumn
            // 
            this.должностьDataGridViewTextBoxColumn.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn.Name = "должностьDataGridViewTextBoxColumn";
            this.должностьDataGridViewTextBoxColumn.ReadOnly = true;
            this.должностьDataGridViewTextBoxColumn.Width = 110;
            // 
            // зарплатаDataGridViewTextBoxColumn
            // 
            this.зарплатаDataGridViewTextBoxColumn.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn.Name = "зарплатаDataGridViewTextBoxColumn";
            this.зарплатаDataGridViewTextBoxColumn.ReadOnly = true;
            this.зарплатаDataGridViewTextBoxColumn.Width = 101;
            // 
            // получитьСписокСотрудниковОтделенияBindingSource
            // 
            this.получитьСписокСотрудниковОтделенияBindingSource.DataMember = "ПолучитьСписокСотрудниковОтделения";
            this.получитьСписокСотрудниковОтделенияBindingSource.DataSource = this.bankDataSetBindingSource;
            // 
            // bankDataSetBindingSource
            // 
            this.bankDataSetBindingSource.DataSource = this.bankDataSet;
            this.bankDataSetBindingSource.Position = 0;
            // 
            // bankDataSet
            // 
            this.bankDataSet.DataSetName = "BankDataSet";
            this.bankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directorDepartmentOperationsGrid
            // 
            this.directorDepartmentOperationsGrid.AllowUserToAddRows = false;
            this.directorDepartmentOperationsGrid.AllowUserToDeleteRows = false;
            this.directorDepartmentOperationsGrid.AutoGenerateColumns = false;
            this.directorDepartmentOperationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorDepartmentOperationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorDepartmentOperationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.суммаDataGridViewTextBoxColumn,
            this.датаПроведенияОперацииDataGridViewTextBoxColumn,
            this.iDОператораDataGridViewTextBoxColumn});
            this.directorDepartmentOperationsGrid.DataSource = this.получитьОперацииОтделенияBindingSource;
            this.directorDepartmentOperationsGrid.Location = new System.Drawing.Point(24, 16);
            this.directorDepartmentOperationsGrid.Name = "directorDepartmentOperationsGrid";
            this.directorDepartmentOperationsGrid.ReadOnly = true;
            this.directorDepartmentOperationsGrid.RowTemplate.Height = 24;
            this.directorDepartmentOperationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorDepartmentOperationsGrid.Size = new System.Drawing.Size(584, 385);
            this.directorDepartmentOperationsGrid.TabIndex = 8;
            this.directorDepartmentOperationsGrid.Visible = false;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            this.суммаDataGridViewTextBoxColumn.ReadOnly = true;
            this.суммаDataGridViewTextBoxColumn.Width = 79;
            // 
            // датаПроведенияОперацииDataGridViewTextBoxColumn
            // 
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.DataPropertyName = "ДатаПроведенияОперации";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.HeaderText = "Дата проведения операции";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.Name = "датаПроведенияОперацииDataGridViewTextBoxColumn";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаПроведенияОперацииDataGridViewTextBoxColumn.Width = 202;
            // 
            // iDОператораDataGridViewTextBoxColumn
            // 
            this.iDОператораDataGridViewTextBoxColumn.DataPropertyName = "IDОператора";
            this.iDОператораDataGridViewTextBoxColumn.HeaderText = "IDОператора";
            this.iDОператораDataGridViewTextBoxColumn.Name = "iDОператораDataGridViewTextBoxColumn";
            this.iDОператораDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDОператораDataGridViewTextBoxColumn.Width = 124;
            // 
            // получитьОперацииОтделенияBindingSource
            // 
            this.получитьОперацииОтделенияBindingSource.DataMember = "ПолучитьОперацииОтделения";
            this.получитьОперацииОтделенияBindingSource.DataSource = this.bankDataSet;
            // 
            // directorDepartmentsGrid
            // 
            this.directorDepartmentsGrid.AllowUserToAddRows = false;
            this.directorDepartmentsGrid.AllowUserToDeleteRows = false;
            this.directorDepartmentsGrid.AutoGenerateColumns = false;
            this.directorDepartmentsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorDepartmentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorDepartmentsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDОтделенияDataGridViewTextBoxColumn1,
            this.городDataGridViewTextBoxColumn});
            this.directorDepartmentsGrid.DataSource = this.отделенияBindingSource;
            this.directorDepartmentsGrid.Location = new System.Drawing.Point(24, 16);
            this.directorDepartmentsGrid.Name = "directorDepartmentsGrid";
            this.directorDepartmentsGrid.ReadOnly = true;
            this.directorDepartmentsGrid.RowTemplate.Height = 24;
            this.directorDepartmentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorDepartmentsGrid.Size = new System.Drawing.Size(424, 385);
            this.directorDepartmentsGrid.TabIndex = 2;
            this.directorDepartmentsGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.directorDepartmentsGrid_MouseClick);
            // 
            // iDОтделенияDataGridViewTextBoxColumn1
            // 
            this.iDОтделенияDataGridViewTextBoxColumn1.DataPropertyName = "IDОтделения";
            this.iDОтделенияDataGridViewTextBoxColumn1.HeaderText = "IDОтделения";
            this.iDОтделенияDataGridViewTextBoxColumn1.Name = "iDОтделенияDataGridViewTextBoxColumn1";
            this.iDОтделенияDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDОтделенияDataGridViewTextBoxColumn1.Width = 124;
            // 
            // городDataGridViewTextBoxColumn
            // 
            this.городDataGridViewTextBoxColumn.DataPropertyName = "Город";
            this.городDataGridViewTextBoxColumn.HeaderText = "Город";
            this.городDataGridViewTextBoxColumn.Name = "городDataGridViewTextBoxColumn";
            this.городDataGridViewTextBoxColumn.ReadOnly = true;
            this.городDataGridViewTextBoxColumn.Width = 77;
            // 
            // отделенияBindingSource
            // 
            this.отделенияBindingSource.DataMember = "Отделения";
            this.отделенияBindingSource.DataSource = this.bankDataSet;
            // 
            // directorShowDepartmentWorkersButton
            // 
            this.directorShowDepartmentWorkersButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorShowDepartmentWorkersButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorShowDepartmentWorkersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorShowDepartmentWorkersButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorShowDepartmentWorkersButton.ForeColor = System.Drawing.Color.Black;
            this.directorShowDepartmentWorkersButton.Location = new System.Drawing.Point(480, 16);
            this.directorShowDepartmentWorkersButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorShowDepartmentWorkersButton.Name = "directorShowDepartmentWorkersButton";
            this.directorShowDepartmentWorkersButton.Size = new System.Drawing.Size(216, 144);
            this.directorShowDepartmentWorkersButton.TabIndex = 3;
            this.directorShowDepartmentWorkersButton.Text = "Список сотрудников отделения";
            this.directorShowDepartmentWorkersButton.UseVisualStyleBackColor = false;
            this.directorShowDepartmentWorkersButton.Click += new System.EventHandler(this.directorShowDepartmentWorkersButton_Click);
            // 
            // directorShowDepartmentOperationsButton
            // 
            this.directorShowDepartmentOperationsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorShowDepartmentOperationsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorShowDepartmentOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorShowDepartmentOperationsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorShowDepartmentOperationsButton.ForeColor = System.Drawing.Color.Black;
            this.directorShowDepartmentOperationsButton.Location = new System.Drawing.Point(734, 16);
            this.directorShowDepartmentOperationsButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorShowDepartmentOperationsButton.Name = "directorShowDepartmentOperationsButton";
            this.directorShowDepartmentOperationsButton.Size = new System.Drawing.Size(216, 144);
            this.directorShowDepartmentOperationsButton.TabIndex = 4;
            this.directorShowDepartmentOperationsButton.Text = "Список операций отделения";
            this.directorShowDepartmentOperationsButton.UseVisualStyleBackColor = false;
            this.directorShowDepartmentOperationsButton.Click += new System.EventHandler(this.directorShowDepartmentOperationsButton_Click);
            // 
            // directorHideDepartmentWorkersButton
            // 
            this.directorHideDepartmentWorkersButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorHideDepartmentWorkersButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorHideDepartmentWorkersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorHideDepartmentWorkersButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorHideDepartmentWorkersButton.ForeColor = System.Drawing.Color.Black;
            this.directorHideDepartmentWorkersButton.Location = new System.Drawing.Point(688, 136);
            this.directorHideDepartmentWorkersButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorHideDepartmentWorkersButton.Name = "directorHideDepartmentWorkersButton";
            this.directorHideDepartmentWorkersButton.Size = new System.Drawing.Size(216, 144);
            this.directorHideDepartmentWorkersButton.TabIndex = 5;
            this.directorHideDepartmentWorkersButton.Text = "Скрыть список сотрудников";
            this.directorHideDepartmentWorkersButton.UseVisualStyleBackColor = false;
            this.directorHideDepartmentWorkersButton.Visible = false;
            this.directorHideDepartmentWorkersButton.Click += new System.EventHandler(this.directorHideDepartmentWorkersButton_Click);
            // 
            // directorHideDepartmentOperationsButton
            // 
            this.directorHideDepartmentOperationsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorHideDepartmentOperationsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorHideDepartmentOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorHideDepartmentOperationsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorHideDepartmentOperationsButton.ForeColor = System.Drawing.Color.Black;
            this.directorHideDepartmentOperationsButton.Location = new System.Drawing.Point(688, 136);
            this.directorHideDepartmentOperationsButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorHideDepartmentOperationsButton.Name = "directorHideDepartmentOperationsButton";
            this.directorHideDepartmentOperationsButton.Size = new System.Drawing.Size(216, 144);
            this.directorHideDepartmentOperationsButton.TabIndex = 10;
            this.directorHideDepartmentOperationsButton.Text = "Скрыть список операций";
            this.directorHideDepartmentOperationsButton.UseVisualStyleBackColor = false;
            this.directorHideDepartmentOperationsButton.Visible = false;
            this.directorHideDepartmentOperationsButton.Click += new System.EventHandler(this.directorHideDepartmentOperationsButton_Click);
            // 
            // directorWorkersPage
            // 
            this.directorWorkersPage.BackColor = System.Drawing.Color.MintCream;
            this.directorWorkersPage.Controls.Add(this.directorActionsLabel);
            this.directorWorkersPage.Controls.Add(this.directorActionsComboBox);
            this.directorWorkersPage.Controls.Add(this.directorGoToMainPageFromWorkersPageButton);
            this.directorWorkersPage.Controls.Add(this.directorWorkerCreditRequestsGrid);
            this.directorWorkersPage.Controls.Add(this.directorWorkerOperationsGrid);
            this.directorWorkersPage.Controls.Add(this.directorWorkersGrid);
            this.directorWorkersPage.Controls.Add(this.directorHideWorkerCreditRequestsButton);
            this.directorWorkersPage.Controls.Add(this.directorHideWorkerOperationsButton);
            this.directorWorkersPage.Controls.Add(this.directorExecuteActionButton);
            this.directorWorkersPage.Location = new System.Drawing.Point(4, 25);
            this.directorWorkersPage.Name = "directorWorkersPage";
            this.directorWorkersPage.Padding = new System.Windows.Forms.Padding(3);
            this.directorWorkersPage.Size = new System.Drawing.Size(974, 524);
            this.directorWorkersPage.TabIndex = 2;
            this.directorWorkersPage.Text = "Сотрудники";
            // 
            // directorActionsLabel
            // 
            this.directorActionsLabel.BackColor = System.Drawing.Color.MintCream;
            this.directorActionsLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorActionsLabel.ForeColor = System.Drawing.Color.Black;
            this.directorActionsLabel.Location = new System.Drawing.Point(24, 8);
            this.directorActionsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.directorActionsLabel.Name = "directorActionsLabel";
            this.directorActionsLabel.Size = new System.Drawing.Size(216, 80);
            this.directorActionsLabel.TabIndex = 20;
            this.directorActionsLabel.Text = "Выберите действие";
            this.directorActionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // directorActionsComboBox
            // 
            this.directorActionsComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.directorActionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directorActionsComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorActionsComboBox.FormattingEnabled = true;
            this.directorActionsComboBox.ItemHeight = 38;
            this.directorActionsComboBox.Items.AddRange(new object[] {
            "Отобразить список операций сотрудника",
            "Отобразить заявки на кредит сотрудника",
            "Уволить сотрудника",
            "Перевести сотрудника в другое отделение",
            "Повысить сотрудника",
            "Нанять нового сотрудника"});
            this.directorActionsComboBox.Location = new System.Drawing.Point(264, 30);
            this.directorActionsComboBox.Name = "directorActionsComboBox";
            this.directorActionsComboBox.Size = new System.Drawing.Size(688, 46);
            this.directorActionsComboBox.TabIndex = 19;
            // 
            // directorGoToMainPageFromWorkersPageButton
            // 
            this.directorGoToMainPageFromWorkersPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorGoToMainPageFromWorkersPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorGoToMainPageFromWorkersPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorGoToMainPageFromWorkersPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorGoToMainPageFromWorkersPageButton.ForeColor = System.Drawing.Color.Black;
            this.directorGoToMainPageFromWorkersPageButton.Location = new System.Drawing.Point(20, 420);
            this.directorGoToMainPageFromWorkersPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorGoToMainPageFromWorkersPageButton.Name = "directorGoToMainPageFromWorkersPageButton";
            this.directorGoToMainPageFromWorkersPageButton.Size = new System.Drawing.Size(222, 80);
            this.directorGoToMainPageFromWorkersPageButton.TabIndex = 2;
            this.directorGoToMainPageFromWorkersPageButton.Text = "На главную";
            this.directorGoToMainPageFromWorkersPageButton.UseVisualStyleBackColor = false;
            this.directorGoToMainPageFromWorkersPageButton.Click += new System.EventHandler(this.directorGoToMainPageFromWorkersPageButton_Click);
            // 
            // directorWorkerCreditRequestsGrid
            // 
            this.directorWorkerCreditRequestsGrid.AllowUserToAddRows = false;
            this.directorWorkerCreditRequestsGrid.AllowUserToDeleteRows = false;
            this.directorWorkerCreditRequestsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorWorkerCreditRequestsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorWorkerCreditRequestsGrid.Location = new System.Drawing.Point(264, 112);
            this.directorWorkerCreditRequestsGrid.Name = "directorWorkerCreditRequestsGrid";
            this.directorWorkerCreditRequestsGrid.ReadOnly = true;
            this.directorWorkerCreditRequestsGrid.RowTemplate.Height = 24;
            this.directorWorkerCreditRequestsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorWorkerCreditRequestsGrid.Size = new System.Drawing.Size(688, 385);
            this.directorWorkerCreditRequestsGrid.TabIndex = 24;
            this.directorWorkerCreditRequestsGrid.Visible = false;
            // 
            // directorWorkerOperationsGrid
            // 
            this.directorWorkerOperationsGrid.AllowUserToAddRows = false;
            this.directorWorkerOperationsGrid.AllowUserToDeleteRows = false;
            this.directorWorkerOperationsGrid.AutoGenerateColumns = false;
            this.directorWorkerOperationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorWorkerOperationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorWorkerOperationsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.суммаDataGridViewTextBoxColumn1,
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1});
            this.directorWorkerOperationsGrid.DataSource = this.получитьОперацииПоСотрудникуBindingSource;
            this.directorWorkerOperationsGrid.Location = new System.Drawing.Point(264, 112);
            this.directorWorkerOperationsGrid.Name = "directorWorkerOperationsGrid";
            this.directorWorkerOperationsGrid.ReadOnly = true;
            this.directorWorkerOperationsGrid.RowTemplate.Height = 24;
            this.directorWorkerOperationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorWorkerOperationsGrid.Size = new System.Drawing.Size(688, 385);
            this.directorWorkerOperationsGrid.TabIndex = 22;
            this.directorWorkerOperationsGrid.Visible = false;
            // 
            // суммаDataGridViewTextBoxColumn1
            // 
            this.суммаDataGridViewTextBoxColumn1.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn1.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn1.Name = "суммаDataGridViewTextBoxColumn1";
            this.суммаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.суммаDataGridViewTextBoxColumn1.Width = 79;
            // 
            // датаПроведенияОперацииDataGridViewTextBoxColumn1
            // 
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1.DataPropertyName = "ДатаПроведенияОперации";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1.HeaderText = "Дата проведения операции";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1.Name = "датаПроведенияОперацииDataGridViewTextBoxColumn1";
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1.ReadOnly = true;
            this.датаПроведенияОперацииDataGridViewTextBoxColumn1.Width = 202;
            // 
            // получитьОперацииПоСотрудникуBindingSource
            // 
            this.получитьОперацииПоСотрудникуBindingSource.DataMember = "ПолучитьОперацииПоСотруднику";
            this.получитьОперацииПоСотрудникуBindingSource.DataSource = this.bankDataSet;
            // 
            // directorWorkersGrid
            // 
            this.directorWorkersGrid.AllowUserToAddRows = false;
            this.directorWorkersGrid.AllowUserToDeleteRows = false;
            this.directorWorkersGrid.AutoGenerateColumns = false;
            this.directorWorkersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorWorkersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorWorkersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDСотрудникаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn1,
            this.iDОтделенияDataGridViewTextBoxColumn,
            this.должностьDataGridViewTextBoxColumn1,
            this.зарплатаDataGridViewTextBoxColumn1});
            this.directorWorkersGrid.DataSource = this.получитьСписокСотрудниковBindingSource;
            this.directorWorkersGrid.Location = new System.Drawing.Point(264, 112);
            this.directorWorkersGrid.Name = "directorWorkersGrid";
            this.directorWorkersGrid.ReadOnly = true;
            this.directorWorkersGrid.RowTemplate.Height = 24;
            this.directorWorkersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.directorWorkersGrid.Size = new System.Drawing.Size(688, 385);
            this.directorWorkersGrid.TabIndex = 8;
            this.directorWorkersGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.directorWorkersGrid_MouseClick);
            // 
            // iDСотрудникаDataGridViewTextBoxColumn
            // 
            this.iDСотрудникаDataGridViewTextBoxColumn.DataPropertyName = "IDСотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.HeaderText = "IDСотрудника";
            this.iDСотрудникаDataGridViewTextBoxColumn.Name = "iDСотрудникаDataGridViewTextBoxColumn";
            this.iDСотрудникаDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDСотрудникаDataGridViewTextBoxColumn.Width = 128;
            // 
            // фИОDataGridViewTextBoxColumn1
            // 
            this.фИОDataGridViewTextBoxColumn1.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn1.Name = "фИОDataGridViewTextBoxColumn1";
            this.фИОDataGridViewTextBoxColumn1.ReadOnly = true;
            this.фИОDataGridViewTextBoxColumn1.Width = 71;
            // 
            // iDОтделенияDataGridViewTextBoxColumn
            // 
            this.iDОтделенияDataGridViewTextBoxColumn.DataPropertyName = "IDОтделения";
            this.iDОтделенияDataGridViewTextBoxColumn.HeaderText = "IDОтделения";
            this.iDОтделенияDataGridViewTextBoxColumn.Name = "iDОтделенияDataGridViewTextBoxColumn";
            this.iDОтделенияDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDОтделенияDataGridViewTextBoxColumn.Width = 124;
            // 
            // должностьDataGridViewTextBoxColumn1
            // 
            this.должностьDataGridViewTextBoxColumn1.DataPropertyName = "Должность";
            this.должностьDataGridViewTextBoxColumn1.HeaderText = "Должность";
            this.должностьDataGridViewTextBoxColumn1.Name = "должностьDataGridViewTextBoxColumn1";
            this.должностьDataGridViewTextBoxColumn1.ReadOnly = true;
            this.должностьDataGridViewTextBoxColumn1.Width = 110;
            // 
            // зарплатаDataGridViewTextBoxColumn1
            // 
            this.зарплатаDataGridViewTextBoxColumn1.DataPropertyName = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn1.HeaderText = "Зарплата";
            this.зарплатаDataGridViewTextBoxColumn1.Name = "зарплатаDataGridViewTextBoxColumn1";
            this.зарплатаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.зарплатаDataGridViewTextBoxColumn1.Width = 101;
            // 
            // получитьСписокСотрудниковBindingSource
            // 
            this.получитьСписокСотрудниковBindingSource.DataMember = "ПолучитьСписокСотрудников";
            this.получитьСписокСотрудниковBindingSource.DataSource = this.bankDataSet;
            // 
            // directorHideWorkerCreditRequestsButton
            // 
            this.directorHideWorkerCreditRequestsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorHideWorkerCreditRequestsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorHideWorkerCreditRequestsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorHideWorkerCreditRequestsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorHideWorkerCreditRequestsButton.ForeColor = System.Drawing.Color.Black;
            this.directorHideWorkerCreditRequestsButton.Location = new System.Drawing.Point(24, 112);
            this.directorHideWorkerCreditRequestsButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorHideWorkerCreditRequestsButton.Name = "directorHideWorkerCreditRequestsButton";
            this.directorHideWorkerCreditRequestsButton.Size = new System.Drawing.Size(216, 136);
            this.directorHideWorkerCreditRequestsButton.TabIndex = 23;
            this.directorHideWorkerCreditRequestsButton.Text = "Скрыть список заявок";
            this.directorHideWorkerCreditRequestsButton.UseVisualStyleBackColor = false;
            this.directorHideWorkerCreditRequestsButton.Visible = false;
            this.directorHideWorkerCreditRequestsButton.Click += new System.EventHandler(this.directorHideWorkerCreditRequestsButton_Click);
            // 
            // directorHideWorkerOperationsButton
            // 
            this.directorHideWorkerOperationsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorHideWorkerOperationsButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorHideWorkerOperationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorHideWorkerOperationsButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorHideWorkerOperationsButton.ForeColor = System.Drawing.Color.Black;
            this.directorHideWorkerOperationsButton.Location = new System.Drawing.Point(24, 112);
            this.directorHideWorkerOperationsButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorHideWorkerOperationsButton.Name = "directorHideWorkerOperationsButton";
            this.directorHideWorkerOperationsButton.Size = new System.Drawing.Size(216, 136);
            this.directorHideWorkerOperationsButton.TabIndex = 16;
            this.directorHideWorkerOperationsButton.Text = "Скрыть список операций";
            this.directorHideWorkerOperationsButton.UseVisualStyleBackColor = false;
            this.directorHideWorkerOperationsButton.Visible = false;
            this.directorHideWorkerOperationsButton.Click += new System.EventHandler(this.directorHideWorkerOperationsButton_Click);
            // 
            // directorExecuteActionButton
            // 
            this.directorExecuteActionButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorExecuteActionButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorExecuteActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorExecuteActionButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorExecuteActionButton.ForeColor = System.Drawing.Color.Black;
            this.directorExecuteActionButton.Location = new System.Drawing.Point(24, 112);
            this.directorExecuteActionButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorExecuteActionButton.Name = "directorExecuteActionButton";
            this.directorExecuteActionButton.Size = new System.Drawing.Size(216, 136);
            this.directorExecuteActionButton.TabIndex = 21;
            this.directorExecuteActionButton.Text = "Выполнить";
            this.directorExecuteActionButton.UseVisualStyleBackColor = false;
            this.directorExecuteActionButton.Click += new System.EventHandler(this.directorExecuteActionButton_Click);
            // 
            // directorStatsPage
            // 
            this.directorStatsPage.BackColor = System.Drawing.Color.MintCream;
            this.directorStatsPage.Controls.Add(this.sumLabel);
            this.directorStatsPage.Controls.Add(this.sumTextBox);
            this.directorStatsPage.Controls.Add(this.directorShowStatisticsGridButton);
            this.directorStatsPage.Controls.Add(this.directorStatisticsDescriptionLabel);
            this.directorStatsPage.Controls.Add(this.directorStatisticsLabel);
            this.directorStatsPage.Controls.Add(this.directorStatisticsDescriptionRichTextBox);
            this.directorStatsPage.Controls.Add(this.directorStatisticsComboBox);
            this.directorStatsPage.Controls.Add(this.directorGoToMainPageFromStatisticsPageButton);
            this.directorStatsPage.Controls.Add(this.directorStatisticsGrid);
            this.directorStatsPage.Location = new System.Drawing.Point(4, 25);
            this.directorStatsPage.Name = "directorStatsPage";
            this.directorStatsPage.Padding = new System.Windows.Forms.Padding(3);
            this.directorStatsPage.Size = new System.Drawing.Size(974, 524);
            this.directorStatsPage.TabIndex = 3;
            this.directorStatsPage.Text = "Статистика";
            // 
            // sumLabel
            // 
            this.sumLabel.BackColor = System.Drawing.Color.MintCream;
            this.sumLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumLabel.ForeColor = System.Drawing.Color.Black;
            this.sumLabel.Location = new System.Drawing.Point(-264, 336);
            this.sumLabel.Margin = new System.Windows.Forms.Padding(0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(392, 48);
            this.sumLabel.TabIndex = 26;
            this.sumLabel.Text = "Сумма";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sumLabel.Visible = false;
            // 
            // sumTextBox
            // 
            this.sumTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumTextBox.Location = new System.Drawing.Point(144, 336);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(224, 45);
            this.sumTextBox.TabIndex = 25;
            this.sumTextBox.Visible = false;
            // 
            // directorShowStatisticsGridButton
            // 
            this.directorShowStatisticsGridButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorShowStatisticsGridButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorShowStatisticsGridButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorShowStatisticsGridButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorShowStatisticsGridButton.ForeColor = System.Drawing.Color.Black;
            this.directorShowStatisticsGridButton.Location = new System.Drawing.Point(144, 224);
            this.directorShowStatisticsGridButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorShowStatisticsGridButton.Name = "directorShowStatisticsGridButton";
            this.directorShowStatisticsGridButton.Size = new System.Drawing.Size(222, 80);
            this.directorShowStatisticsGridButton.TabIndex = 24;
            this.directorShowStatisticsGridButton.Text = "Отобразить";
            this.directorShowStatisticsGridButton.UseVisualStyleBackColor = false;
            this.directorShowStatisticsGridButton.Click += new System.EventHandler(this.directorShowStatisticsGridButton_Click);
            // 
            // directorStatisticsDescriptionLabel
            // 
            this.directorStatisticsDescriptionLabel.BackColor = System.Drawing.Color.MintCream;
            this.directorStatisticsDescriptionLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorStatisticsDescriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.directorStatisticsDescriptionLabel.Location = new System.Drawing.Point(24, 128);
            this.directorStatisticsDescriptionLabel.Margin = new System.Windows.Forms.Padding(0);
            this.directorStatisticsDescriptionLabel.Name = "directorStatisticsDescriptionLabel";
            this.directorStatisticsDescriptionLabel.Size = new System.Drawing.Size(344, 48);
            this.directorStatisticsDescriptionLabel.TabIndex = 23;
            this.directorStatisticsDescriptionLabel.Text = "Описание";
            this.directorStatisticsDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // directorStatisticsLabel
            // 
            this.directorStatisticsLabel.BackColor = System.Drawing.Color.MintCream;
            this.directorStatisticsLabel.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorStatisticsLabel.ForeColor = System.Drawing.Color.Black;
            this.directorStatisticsLabel.Location = new System.Drawing.Point(16, 24);
            this.directorStatisticsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.directorStatisticsLabel.Name = "directorStatisticsLabel";
            this.directorStatisticsLabel.Size = new System.Drawing.Size(352, 48);
            this.directorStatisticsLabel.TabIndex = 22;
            this.directorStatisticsLabel.Text = "Элемент статистики";
            this.directorStatisticsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // directorStatisticsDescriptionRichTextBox
            // 
            this.directorStatisticsDescriptionRichTextBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorStatisticsDescriptionRichTextBox.Location = new System.Drawing.Point(400, 88);
            this.directorStatisticsDescriptionRichTextBox.Name = "directorStatisticsDescriptionRichTextBox";
            this.directorStatisticsDescriptionRichTextBox.ReadOnly = true;
            this.directorStatisticsDescriptionRichTextBox.Size = new System.Drawing.Size(552, 120);
            this.directorStatisticsDescriptionRichTextBox.TabIndex = 21;
            this.directorStatisticsDescriptionRichTextBox.Text = "";
            // 
            // directorStatisticsComboBox
            // 
            this.directorStatisticsComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.directorStatisticsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directorStatisticsComboBox.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorStatisticsComboBox.FormattingEnabled = true;
            this.directorStatisticsComboBox.ItemHeight = 38;
            this.directorStatisticsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.directorStatisticsComboBox.Location = new System.Drawing.Point(400, 24);
            this.directorStatisticsComboBox.Name = "directorStatisticsComboBox";
            this.directorStatisticsComboBox.Size = new System.Drawing.Size(160, 46);
            this.directorStatisticsComboBox.TabIndex = 20;
            this.directorStatisticsComboBox.SelectedIndexChanged += new System.EventHandler(this.directorStatisticsComboBox_SelectedIndexChanged);
            // 
            // directorGoToMainPageFromStatisticsPageButton
            // 
            this.directorGoToMainPageFromStatisticsPageButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.directorGoToMainPageFromStatisticsPageButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.directorGoToMainPageFromStatisticsPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directorGoToMainPageFromStatisticsPageButton.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorGoToMainPageFromStatisticsPageButton.ForeColor = System.Drawing.Color.Black;
            this.directorGoToMainPageFromStatisticsPageButton.Location = new System.Drawing.Point(20, 420);
            this.directorGoToMainPageFromStatisticsPageButton.Margin = new System.Windows.Forms.Padding(4);
            this.directorGoToMainPageFromStatisticsPageButton.Name = "directorGoToMainPageFromStatisticsPageButton";
            this.directorGoToMainPageFromStatisticsPageButton.Size = new System.Drawing.Size(222, 80);
            this.directorGoToMainPageFromStatisticsPageButton.TabIndex = 3;
            this.directorGoToMainPageFromStatisticsPageButton.Text = "На главную";
            this.directorGoToMainPageFromStatisticsPageButton.UseVisualStyleBackColor = false;
            this.directorGoToMainPageFromStatisticsPageButton.Click += new System.EventHandler(this.directorGoToMainPageFromStatisticsPageButton_Click);
            // 
            // directorStatisticsGrid
            // 
            this.directorStatisticsGrid.AllowUserToAddRows = false;
            this.directorStatisticsGrid.AllowUserToDeleteRows = false;
            this.directorStatisticsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.directorStatisticsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directorStatisticsGrid.Location = new System.Drawing.Point(400, 224);
            this.directorStatisticsGrid.Name = "directorStatisticsGrid";
            this.directorStatisticsGrid.ReadOnly = true;
            this.directorStatisticsGrid.RowTemplate.Height = 24;
            this.directorStatisticsGrid.Size = new System.Drawing.Size(552, 272);
            this.directorStatisticsGrid.TabIndex = 27;
            // 
            // получитьСписокСотрудниковОтделенияTableAdapter
            // 
            this.получитьСписокСотрудниковОтделенияTableAdapter.ClearBeforeFill = true;
            // 
            // получитьОперацииОтделенияTableAdapter
            // 
            this.получитьОперацииОтделенияTableAdapter.ClearBeforeFill = true;
            // 
            // выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter
            // 
            this.выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter.ClearBeforeFill = true;
            // 
            // получитьОперацииПоСотрудникуTableAdapter
            // 
            this.получитьОперацииПоСотрудникуTableAdapter.ClearBeforeFill = true;
            // 
            // отделенияTableAdapter
            // 
            this.отделенияTableAdapter.ClearBeforeFill = true;
            // 
            // получитьСписокСотрудниковTableAdapter
            // 
            this.получитьСписокСотрудниковTableAdapter.ClearBeforeFill = true;
            // 
            // получитьЗаявкиНаКредитКредитораBindingSource
            // 
            this.получитьЗаявкиНаКредитКредитораBindingSource.DataMember = "ПолучитьЗаявкиНаКредитКредитора";
            this.получитьЗаявкиНаКредитКредитораBindingSource.DataSource = this.bankDataSet;
            // 
            // получитьЗаявкиНаКредитКредитораTableAdapter
            // 
            this.получитьЗаявкиНаКредитКредитораTableAdapter.ClearBeforeFill = true;
            // 
            // получитьЗаявкиНаКредитОператораBindingSource
            // 
            this.получитьЗаявкиНаКредитОператораBindingSource.DataMember = "ПолучитьЗаявкиНаКредитОператора";
            this.получитьЗаявкиНаКредитОператораBindingSource.DataSource = this.bankDataSet;
            // 
            // получитьЗаявкиНаКредитОператораTableAdapter
            // 
            this.получитьЗаявкиНаКредитОператораTableAdapter.ClearBeforeFill = true;
            // 
            // bankDataSet1
            // 
            this.bankDataSet1.DataSetName = "BankDataSet";
            this.bankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource
            // 
            this.найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource.DataMember = "НайтиОтделенияСМаксимальнымКоличествомСотрудников";
            this.найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource.DataSource = this.bankDataSet1;
            // 
            // найтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter
            // 
            this.найтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter.ClearBeforeFill = true;
            // 
            // найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource
            // 
            this.найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource.DataMember = "НайтиОператораОбработавшегоНаибольшуюСуммуДенег";
            this.найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource.DataSource = this.bankDataSet1;
            // 
            // найтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter
            // 
            this.найтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter.ClearBeforeFill = true;
            // 
            // найтиКредитораНеОдобрившегоНиОдинКредитBindingSource
            // 
            this.найтиКредитораНеОдобрившегоНиОдинКредитBindingSource.DataMember = "НайтиКредитораНеОдобрившегоНиОдинКредит";
            this.найтиКредитораНеОдобрившегоНиОдинКредитBindingSource.DataSource = this.bankDataSet1;
            // 
            // найтиКредитораНеОдобрившегоНиОдинКредитTableAdapter
            // 
            this.найтиКредитораНеОдобрившегоНиОдинКредитTableAdapter.ClearBeforeFill = true;
            // 
            // рассчитатьКоличествоКлиентовПоГородамBindingSource
            // 
            this.рассчитатьКоличествоКлиентовПоГородамBindingSource.DataMember = "РассчитатьКоличествоКлиентовПоГородам";
            this.рассчитатьКоличествоКлиентовПоГородамBindingSource.DataSource = this.bankDataSet1;
            // 
            // рассчитатьКоличествоКлиентовПоГородамTableAdapter
            // 
            this.рассчитатьКоличествоКлиентовПоГородамTableAdapter.ClearBeforeFill = true;
            // 
            // выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource
            // 
            this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource.DataMember = "ВыбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГор" +
    "ода";
            this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource.DataSource = this.bankDataSet;
            // 
            // выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter
            // 
            this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter.ClearBeforeFill = true;
            // 
            // получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource
            // 
            this.получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource.DataMember = "ПолучитьСотрудниковРаботавшихСПремиумКлиентами";
            this.получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource.DataSource = this.bankDataSet;
            // 
            // получитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter
            // 
            this.получитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter.ClearBeforeFill = true;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.directorTabControl);
            this.Name = "DirectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Директор";
            this.Load += new System.EventHandler(this.DirectorForm_Load);
            this.directorTabControl.ResumeLayout(false);
            this.directorMainPage.ResumeLayout(false);
            this.directorDepartmentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directorDepartmentWorkersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСписокСотрудниковОтделенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorDepartmentOperationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьОперацииОтделенияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorDepartmentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отделенияBindingSource)).EndInit();
            this.directorWorkersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directorWorkerCreditRequestsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorWorkerOperationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьОперацииПоСотрудникуBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directorWorkersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСписокСотрудниковBindingSource)).EndInit();
            this.directorStatsPage.ResumeLayout(false);
            this.directorStatsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorStatisticsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьЗаявкиНаКредитКредитораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьЗаявкиНаКредитОператораBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.найтиКредитораНеОдобрившегоНиОдинКредитBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.рассчитатьКоличествоКлиентовПоГородамBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl directorTabControl;
        private System.Windows.Forms.TabPage directorMainPage;
        private System.Windows.Forms.TabPage directorDepartmentsPage;
        private System.Windows.Forms.TabPage directorWorkersPage;
        private System.Windows.Forms.Button directorShowWorkersButton;
        private System.Windows.Forms.Button directorShowDepartmentsButton;
        private System.Windows.Forms.Button directorGoToMainPageFromDepartmentsPageButton;
        private System.Windows.Forms.Button directorGoToMainPageFromWorkersPageButton;
        private System.Windows.Forms.DataGridView directorDepartmentsGrid;
        private BankDataSet bankDataSet;
        private System.Windows.Forms.Button directorCloseDepartmentButton;
        private System.Windows.Forms.Button directorShowDepartmentOperationsButton;
        private System.Windows.Forms.Button directorShowDepartmentWorkersButton;
        private System.Windows.Forms.Button directorHideDepartmentWorkersButton;
        private System.Windows.Forms.DataGridView directorDepartmentWorkersGrid;
        private System.Windows.Forms.DataGridView directorDepartmentOperationsGrid;
        private System.Windows.Forms.BindingSource bankDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource получитьСписокСотрудниковОтделенияBindingSource;
        private BankDataSetTableAdapters.ПолучитьСписокСотрудниковОтделенияTableAdapter получитьСписокСотрудниковОтделенияTableAdapter;
        private System.Windows.Forms.Button directorAddNewDepartmentButton;
        private System.Windows.Forms.Button directorHideDepartmentOperationsButton;
        private System.Windows.Forms.DataGridView directorWorkersGrid;
        private System.Windows.Forms.Button directorMoveDepartmentButton;
        private System.Windows.Forms.Button directorShowStatisticsButton;
        private System.Windows.Forms.TabPage directorStatsPage;
        private System.Windows.Forms.Button directorGoToMainPageFromStatisticsPageButton;
        private System.Windows.Forms.BindingSource получитьОперацииОтделенияBindingSource;
        private BankDataSetTableAdapters.ПолучитьОперацииОтделенияTableAdapter получитьОперацииОтделенияTableAdapter;
        private System.Windows.Forms.ComboBox directorActionsComboBox;
        private System.Windows.Forms.Button directorHideWorkerOperationsButton;
        private System.Windows.Forms.Label directorActionsLabel;
        private System.Windows.Forms.Button directorExecuteActionButton;
        private System.Windows.Forms.DataGridView directorWorkerOperationsGrid;
        private System.Windows.Forms.ComboBox directorStatisticsComboBox;
        private System.Windows.Forms.Label directorStatisticsDescriptionLabel;
        private System.Windows.Forms.Label directorStatisticsLabel;
        private System.Windows.Forms.RichTextBox directorStatisticsDescriptionRichTextBox;
        private System.Windows.Forms.Button directorShowStatisticsGridButton;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.DataGridView directorStatisticsGrid;
        private System.Windows.Forms.BindingSource выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяBindingSource;
        private BankDataSetTableAdapters.ВыбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter;
        private System.Windows.Forms.DataGridView directorWorkerCreditRequestsGrid;
        private System.Windows.Forms.Button directorHideWorkerCreditRequestsButton;
        private System.Windows.Forms.BindingSource получитьОперацииПоСотрудникуBindingSource;
        private BankDataSetTableAdapters.ПолучитьОперацииПоСотрудникуTableAdapter получитьОперацииПоСотрудникуTableAdapter;
        private System.Windows.Forms.BindingSource получитьЗаявкиНаКредитСотрудникаBindingSource;
        private System.Windows.Forms.BindingSource отделенияBindingSource;
        private BankDataSetTableAdapters.ОтделенияTableAdapter отделенияTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОтделенияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn городDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource получитьСписокСотрудниковBindingSource;
        private BankDataSetTableAdapters.ПолучитьСписокСотрудниковTableAdapter получитьСписокСотрудниковTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDСотрудникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОтделенияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn должностьDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn зарплатаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource получитьЗаявкиНаКредитКредитораBindingSource;
        private BankDataSetTableAdapters.ПолучитьЗаявкиНаКредитКредитораTableAdapter получитьЗаявкиНаКредитКредитораTableAdapter;
        private System.Windows.Forms.BindingSource получитьЗаявкиНаКредитОператораBindingSource;
        private BankDataSetTableAdapters.ПолучитьЗаявкиНаКредитОператораTableAdapter получитьЗаявкиНаКредитОператораTableAdapter;
        private BankDataSet bankDataSet1;
        private System.Windows.Forms.BindingSource найтиОтделенияСМаксимальнымКоличествомСотрудниковBindingSource;
        private BankDataSetTableAdapters.НайтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter найтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter;
        private System.Windows.Forms.BindingSource найтиОператораОбработавшегоНаибольшуюСуммуДенегBindingSource;
        private BankDataSetTableAdapters.НайтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter найтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter;
        private System.Windows.Forms.BindingSource найтиКредитораНеОдобрившегоНиОдинКредитBindingSource;
        private BankDataSetTableAdapters.НайтиКредитораНеОдобрившегоНиОдинКредитTableAdapter найтиКредитораНеОдобрившегоНиОдинКредитTableAdapter;
        private System.Windows.Forms.BindingSource рассчитатьКоличествоКлиентовПоГородамBindingSource;
        private BankDataSetTableAdapters.РассчитатьКоличествоКлиентовПоГородамTableAdapter рассчитатьКоличествоКлиентовПоГородамTableAdapter;
        private System.Windows.Forms.BindingSource выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаBindingSource;
        private BankDataSetTableAdapters.ВыбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter;
        private System.Windows.Forms.BindingSource получитьСотрудниковРаботавшихСПремиумКлиентамиBindingSource;
        private BankDataSetTableAdapters.ПолучитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter получитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПроведенияОперацииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОператораDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПроведенияОперацииDataGridViewTextBoxColumn1;
    }
}