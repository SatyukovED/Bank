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
    public partial class MoveWorkerForm : Form
    {
        private DirectorForm df;

        public MoveWorkerForm(DirectorForm df)
        {
            InitializeComponent();
            this.df = df;
            BankDataSet.ПолучитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомDataTable dt = 
                new BankDataSet.ПолучитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомDataTable();
            получитьДанныеОтделенийОднойСтрокойБезОтделенияСКонкретнымСотрудникомTableAdapter.Fill(dt, df.getSelectedWorkerID());
            departmentsToMoveWorkerComboBox.DataSource = dt;
            departmentsToMoveWorkerComboBox.DisplayMember = "Отделение";
            departmentsToMoveWorkerComboBox.ValueMember = "IDОтделения";
        }

        private void moveWorkerButton_Click(object sender, EventArgs e)
        {
            if (departmentsToMoveWorkerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите отделение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QueriesTableAdapter ta = new QueriesTableAdapter();
            try
            {
                int selectedWorkerRow = df.selectedWorkerRow;
                ta.ПеревестиСотрудника(df.getSelectedWorkerID(), (int)departmentsToMoveWorkerComboBox.SelectedValue);
                MessageBox.Show("Сотрудник переведен в отделение " + departmentsToMoveWorkerComboBox.Text);
                df.updateWorkersGrid();
                df.setPreviousWorkerSelection(selectedWorkerRow);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Сотрудник не был переведен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
