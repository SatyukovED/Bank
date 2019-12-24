using Bank.BankDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class DirectorForm : Form
    {
        public int selectedDepartmentRow;
        public int selectedWorkerRow;
        private QueriesTableAdapter ta = new QueriesTableAdapter();

        public DirectorForm()
        {
            InitializeComponent();
        }

        private void DirectorForm_Load(object sender, EventArgs e)
        {
            updateDepartmentsGrid();
            updateWorkersGrid();
            selectedDepartmentRow = 0;
            selectedWorkerRow = 0;
        }

        private void directorShowDepartmentsButton_Click(object sender, EventArgs e)
        {
            directorTabControl.SelectedTab = directorDepartmentsPage;
        }

        private void directorShowWorkersButton_Click(object sender, EventArgs e)
        {
            directorTabControl.SelectedTab = directorWorkersPage;
        }

        private void directorShowStatisticsButton_Click(object sender, EventArgs e)
        {
            directorTabControl.SelectedTab = directorStatsPage;
        }

        private void directorDepartmentsGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedDepartmentRow = directorDepartmentsGrid.CurrentRow.Index;
        }

        private void directorShowDepartmentWorkersButton_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentRow == -1)
            {
                MessageBox.Show("Выберите отделение", "Отделение не выбрано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            directorDepartmentWorkersGrid.Visible = true;
            directorHideDepartmentWorkersButton.Visible = true;
            hideMainDepartmentsControls();
            updateDepartmentWorkersGrid();
        }

        private void directorHideDepartmentWorkersButton_Click(object sender, EventArgs e)
        {
            directorDepartmentWorkersGrid.Visible = false;
            directorHideDepartmentWorkersButton.Visible = false;
            showMainDepartmentsControls();
        }

        private void directorShowDepartmentOperationsButton_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentRow == -1)
            {
                MessageBox.Show("Выберите отделение", "Отделение не выбрано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            directorDepartmentOperationsGrid.Visible = true;
            directorHideDepartmentOperationsButton.Visible = true;
            hideMainDepartmentsControls();
            updateDepartmentOperationsGrid();
        }

        private void directorHideDepartmentOperationsButton_Click(object sender, EventArgs e)
        {
            directorDepartmentOperationsGrid.Visible = false;
            directorHideDepartmentOperationsButton.Visible = false;
            showMainDepartmentsControls();
        }

        private void directorCloseDepartmentButton_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentRow == -1)
            {
                MessageBox.Show("Выберите отделение", "Отделение не выбрано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string message = "Вы действительно хотите закрыть отделение?";
                string caption = "Подтверждение закрытия";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    ta.ЗакрытьОтделение(getSelectedDepartmentID());
                    MessageBox.Show("Отделение закрыто");
                    updateDepartmentsGrid();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Отделение не было закрыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void directorMoveDepartmentButton_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentRow == -1)
            {
                MessageBox.Show("Выберите отделение", "Отделение не выбрано", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MoveDepartmentForm mf = new MoveDepartmentForm(this);
            mf.Show();
        }

        private void directorAddNewDepartmentButton_Click(object sender, EventArgs e)
        {
            AddNewDepartmentForm af = new AddNewDepartmentForm(this);
            af.Show();
        }

        private void directorGoToMainPageFromDepartmentsPageButton_Click(object sender, EventArgs e)
        {
            directorTabControl.SelectedTab = directorMainPage;
        }

        private void directorWorkersGrid_MouseClick(object sender, MouseEventArgs e)
        {
            selectedWorkerRow = directorWorkersGrid.CurrentRow.Index;
        }

        private void directorExecuteActionButton_Click(object sender, EventArgs e)
        {
            int choice = directorActionsComboBox.SelectedIndex;
            switch (choice)
            {
                case 0:
                    {
                        if (selectedWorkerRow == -1)
                        {
                            MessageBox.Show("Выберите сотрудника", "Сотрудник не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Младший кредитор"
                                || directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Кредитор"
                                || directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Старший кредитор")
                        {
                            MessageBox.Show("Кредиторы не проводят операции клиентов");
                            return;
                        }
                        directorWorkerOperationsGrid.DataSource = null;
                        directorActionsComboBox.Visible = false;
                        directorActionsLabel.Visible = false;
                        directorExecuteActionButton.Visible = false;
                        directorWorkersGrid.Visible = false;
                        directorHideWorkerOperationsButton.Visible = true;
                        directorWorkerOperationsGrid.Visible = true;
                        BankDataSet.ПолучитьОперацииПоСотрудникуDataTable dt =
                            new BankDataSet.ПолучитьОперацииПоСотрудникуDataTable();
                        получитьОперацииПоСотрудникуTableAdapter.Fill(dt, getSelectedWorkerID());
                        directorWorkerOperationsGrid.DataSource = dt;
                        break;
                    }
                case 1:
                    {
                        if (selectedWorkerRow == -1)
                        {
                            MessageBox.Show("Выберите сотрудника", "Сотрудник не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        directorWorkerCreditRequestsGrid.DataSource = null;
                        directorActionsComboBox.Visible = false;
                        directorActionsLabel.Visible = false;
                        directorExecuteActionButton.Visible = false;
                        directorWorkersGrid.Visible = false;
                        directorHideWorkerCreditRequestsButton.Visible = true;
                        directorWorkerCreditRequestsGrid.Visible = true;
                        if (directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Младший кредитор"
                                || directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Кредитор"
                                || directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Старший кредитор")
                        {
                            BankDataSet.ПолучитьЗаявкиНаКредитКредитораDataTable dt =
                                new BankDataSet.ПолучитьЗаявкиНаКредитКредитораDataTable();
                            получитьЗаявкиНаКредитКредитораTableAdapter.Fill(dt, getSelectedWorkerID());
                            directorWorkerCreditRequestsGrid.DataSource = dt;
                        }
                        else
                        {
                            BankDataSet.ПолучитьЗаявкиНаКредитОператораDataTable dt =
                                new BankDataSet.ПолучитьЗаявкиНаКредитОператораDataTable();
                            получитьЗаявкиНаКредитОператораTableAdapter.Fill(dt, getSelectedWorkerID());
                            directorWorkerCreditRequestsGrid.DataSource = dt;
                        }
                        break;
                    }
                case 2:
                    {
                        if (selectedWorkerRow == -1)
                        {
                            MessageBox.Show("Выберите сотрудника", "Сотрудник не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        try
                        {
                            string message = "Вы действительно хотите уволить сотрудника?";
                            string caption = "Подтверждение увольнения";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                ta.УволитьСотрудника(getSelectedWorkerID());
                                MessageBox.Show("Сотрудник уволен");
                                updateWorkersGrid();
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Сотрудник не был уволен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case 3:
                    {
                        if (selectedWorkerRow == -1)
                        {
                            MessageBox.Show("Выберите сотрудника", "Сотрудник не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        MoveWorkerForm mf = new MoveWorkerForm(this);
                        mf.Show();
                        break;
                    }
                case 4:
                    {
                        if (selectedWorkerRow == -1)
                        {
                            MessageBox.Show("Выберите сотрудника", "Сотрудник не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        if (directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Старший оператор"
                                || directorWorkersGrid.Rows[selectedWorkerRow].Cells[3].Value.ToString() == "Старший кредитор")
                        {
                            MessageBox.Show("Сотрудник уже достиг вершины карьерной лестницы\nпо своей должности!",
                                                "Куда уж дальше то?");
                            return;
                        }
                        try
                        {
                            string message = "Подтвердите повышение сотрудника";
                            string caption = "";
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result;
                            result = MessageBox.Show(message, caption, buttons);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                ta.ПовыситьСотрудника(getSelectedWorkerID());
                                MessageBox.Show("Сотрудник повышен");
                                int tempSelectedWorkerRow = selectedWorkerRow;
                                updateWorkersGrid();
                                setPreviousWorkerSelection(tempSelectedWorkerRow);
                            }

                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Сотрудник не был повышен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        break;
                    }
                case 5:
                    {
                        addNewWorkerForm af = new addNewWorkerForm(this);
                        af.Show();
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Не выбрано действие, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private void directorHideWorkerOperationsButton_Click(object sender, EventArgs e)
        {
            directorActionsComboBox.Visible = true;
            directorActionsLabel.Visible = true;
            directorExecuteActionButton.Visible = true;
            directorWorkersGrid.Visible = true;
            directorHideWorkerOperationsButton.Visible = false;
            directorWorkerOperationsGrid.Visible = false;
        }

        private void directorHideWorkerCreditRequestsButton_Click(object sender, EventArgs e)
        {
            directorActionsComboBox.Visible = true;
            directorActionsLabel.Visible = true;
            directorExecuteActionButton.Visible = true;
            directorWorkersGrid.Visible = true;
            directorHideWorkerCreditRequestsButton.Visible = false;
            directorWorkerCreditRequestsGrid.Visible = false;
        }

        private void directorGoToMainPageFromWorkersPageButton_Click(object sender, EventArgs e)
        {
            directorTabControl.SelectedTab = directorMainPage;
        }

        private void directorStatisticsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sumLabel.Visible = false;
            sumTextBox.Visible = false;
            directorStatisticsGrid.DataSource = null;
            switch (directorStatisticsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Рассчитать количество клиентов по городам";
                        break;
                    }
                case 1:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Найти отделения с максимальным количеством сотрудников";
                        break;
                    }
                case 2:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Выбрать отделения, в которых все банкиры-операторы работали с суммами, большими, чем заданная";
                        sumLabel.Visible = true;
                        sumTextBox.Visible = true;
                        break;
                    }
                case 3:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Выбрать отделения, в которых были открыты кредиты для всех клиентов с открытыми кредитами из города";
                        break;
                    }
                case 4:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Получить сотрудников, работавших с Премиум клиентами";
                        break;
                    }
                case 5:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Найти банкиров-операторов, обработавших наибольшую сумму денег";
                        break;
                    }
                case 6:
                    {
                        directorStatisticsDescriptionRichTextBox.Text = "Найти кредиторов, не одобривших ни один кредит";
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Не выбран элемент статистики, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private void directorShowStatisticsGridButton_Click(object sender, EventArgs e)
        {
            if (directorStatisticsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран элемент статистики, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            switch (directorStatisticsComboBox.SelectedIndex)
            {
                case 0:
                    {
                        BankDataSet.РассчитатьКоличествоКлиентовПоГородамDataTable dt =
                            new BankDataSet.РассчитатьКоличествоКлиентовПоГородамDataTable();
                        рассчитатьКоличествоКлиентовПоГородамTableAdapter.Fill(dt);
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                case 1:
                    {
                        BankDataSet.НайтиОтделенияСМаксимальнымКоличествомСотрудниковDataTable dt =
                            new BankDataSet.НайтиОтделенияСМаксимальнымКоличествомСотрудниковDataTable();
                        найтиОтделенияСМаксимальнымКоличествомСотрудниковTableAdapter.Fill(dt);
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                case 2:
                    {
                        if (sumTextBox.Text == "")
                        {
                            MessageBox.Show("Введите сумму", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        BankDataSet.ВыбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяDataTable dt =
                            new BankDataSet.ВыбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяDataTable();
                        выбратьОтделенияВКоторыхВсеБанкирыОператорыРаботалиССуммамиБольшимиЧемЗаданнаяTableAdapter.Fill(dt, decimal.Parse(sumTextBox.Text));
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                case 3:
                    {
                        BankDataSet.ВыбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаDataTable dt =
                            new BankDataSet.ВыбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаDataTable();
                        выбратьОтделенияВКоторыхБылиОткрытыКредитыДляВсехКлиентовСОткрытымиКредитамиИзГородаTableAdapter.Fill(dt);
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                case 4:
                    {
                        BankDataSet.ПолучитьСотрудниковРаботавшихСПремиумКлиентамиDataTable dt =
                            new BankDataSet.ПолучитьСотрудниковРаботавшихСПремиумКлиентамиDataTable();
                        получитьСотрудниковРаботавшихСПремиумКлиентамиTableAdapter.Fill(dt);
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                case 5:
                    {
                        BankDataSet.НайтиОператораОбработавшегоНаибольшуюСуммуДенегDataTable dt =
                            new BankDataSet.НайтиОператораОбработавшегоНаибольшуюСуммуДенегDataTable();
                        найтиОператораОбработавшегоНаибольшуюСуммуДенегTableAdapter.Fill(dt);
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                case 6:
                    {
                        BankDataSet.НайтиКредитораНеОдобрившегоНиОдинКредитDataTable dt =
                            new BankDataSet.НайтиКредитораНеОдобрившегоНиОдинКредитDataTable();
                        найтиКредитораНеОдобрившегоНиОдинКредитTableAdapter.Fill(dt);
                        directorStatisticsGrid.DataSource = dt;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Не выбран элемент статистики, повторите попытку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }

            }
        }

        private void directorGoToMainPageFromStatisticsPageButton_Click(object sender, EventArgs e)
        {
            directorTabControl.SelectedTab = directorMainPage;
        }

        public int getSelectedDepartmentID()
        {
            return (int)directorDepartmentsGrid.Rows[selectedDepartmentRow].Cells[0].Value;
        }

        public int getSelectedWorkerID()
        {
            return (int)directorWorkersGrid.Rows[selectedWorkerRow].Cells[0].Value;
        }

        public void updateDepartmentsGrid()
        {
            this.отделенияTableAdapter.Fill(this.bankDataSet.Отделения);
            directorDepartmentsGrid.ClearSelection();
            selectedDepartmentRow = -1;
        }

        public void updateWorkersGrid()
        {
            this.получитьСписокСотрудниковTableAdapter.Fill(this.bankDataSet.ПолучитьСписокСотрудников);
            directorWorkersGrid.ClearSelection();
            selectedWorkerRow = -1;
        }

        public void updateDepartmentWorkersGrid()
        {
            BankDataSet.ПолучитьСписокСотрудниковОтделенияDataTable dt = new BankDataSet.ПолучитьСписокСотрудниковОтделенияDataTable();
            получитьСписокСотрудниковОтделенияTableAdapter.Fill(dt, getSelectedDepartmentID());
            directorDepartmentWorkersGrid.DataSource = dt;
        }

        public void updateDepartmentOperationsGrid()
        {
            BankDataSet.ПолучитьОперацииОтделенияDataTable dt = new BankDataSet.ПолучитьОперацииОтделенияDataTable();
            получитьОперацииОтделенияTableAdapter.Fill(dt, getSelectedDepartmentID());
            directorDepartmentOperationsGrid.DataSource = dt;
        }

        public void setPreviousDepartmentSelection(int selectedDepartmentRowNumber)
        {
            directorDepartmentsGrid.ClearSelection();
            selectedDepartmentRow = selectedDepartmentRowNumber;
            directorDepartmentsGrid.Rows[selectedDepartmentRowNumber].Selected = true;
        }

        public void setPreviousWorkerSelection(int selectedWorkerRowNumber)
        {
            directorWorkersGrid.ClearSelection();
            selectedWorkerRow = selectedWorkerRowNumber;
            directorWorkersGrid.Rows[selectedWorkerRowNumber].Selected = true;
        }

        private void showMainDepartmentsControls()
        {
            directorShowDepartmentWorkersButton.Visible = true;
            directorShowDepartmentOperationsButton.Visible = true;
            directorCloseDepartmentButton.Visible = true;
            directorAddNewDepartmentButton.Visible = true;
            directorMoveDepartmentButton.Visible = true;
            directorDepartmentsGrid.Visible = true;
        }

        private void hideMainDepartmentsControls()
        {
            directorShowDepartmentWorkersButton.Visible = false;
            directorShowDepartmentOperationsButton.Visible = false;
            directorCloseDepartmentButton.Visible = false;
            directorAddNewDepartmentButton.Visible = false;
            directorMoveDepartmentButton.Visible = false;
            directorDepartmentsGrid.Visible = false;
        }
    }
}
