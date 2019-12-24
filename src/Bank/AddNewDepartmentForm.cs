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
    public partial class AddNewDepartmentForm : Form
    {
        private DirectorForm df;

        public AddNewDepartmentForm(DirectorForm df)
        {
            InitializeComponent();
            this.df = df;
        }

        private void openNewDepartmentButton_Click(object sender, EventArgs e)
        {
            if (newDepartmentTownTextBox.Text == "")
            {
                MessageBox.Show("Введите название города", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QueriesTableAdapter ta = new QueriesTableAdapter();
            try
            {
                ta.ОткрытьОтделение(newDepartmentTownTextBox.Text);
                MessageBox.Show("Отделение открыто");
                df.updateDepartmentsGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Отделение не было открыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
