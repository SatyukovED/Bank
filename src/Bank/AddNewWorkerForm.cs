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
    public partial class addNewWorkerForm : Form
    {
        private DirectorForm df;

        public addNewWorkerForm(DirectorForm df)
        {
            InitializeComponent();
            this.df = df;
            BankDataSet.ПолучитьДанныеОтделенийОднойСтрокойDataTable dt =
                new BankDataSet.ПолучитьДанныеОтделенийОднойСтрокойDataTable();
            получитьДанныеОтделенийОднойСтрокойTableAdapter.Fill(dt);
            newWorkerDepartmentComboBox.DataSource = dt;
            newWorkerDepartmentComboBox.DisplayMember = "Отделение";
            newWorkerDepartmentComboBox.ValueMember = "IDОтделения";
        }

        private void addNewWorkerButton_Click(object sender, EventArgs e)
        {
            if (newWorkerNameTextBox.Text == "")
            {
                MessageBox.Show("Введите ФИО сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QueriesTableAdapter ta = new QueriesTableAdapter();
            int newWorkerType = (newWorkerPositionComboBox.SelectedIndex == 0) ? 1 : 4;
            try
            {
                ta.ДобавитьСотрудника(newWorkerNameTextBox.Text, (int)newWorkerDepartmentComboBox.SelectedValue, newWorkerType);
                MessageBox.Show("Сотрядник нанят");
                df.updateWorkersGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Сотрудник не был нанят", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
