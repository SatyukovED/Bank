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
    public partial class MoveDepartmentForm : Form
    {
        private DirectorForm df;

        public MoveDepartmentForm(DirectorForm df)
        {
            InitializeComponent();
            this.df = df;
        }

        private void moveDepartmentButton_Click(object sender, EventArgs e)
        {
            if (moveDepartmentTownTextBox.Text == "")
            {
                MessageBox.Show("Введите название города", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            QueriesTableAdapter ta = new QueriesTableAdapter();
            try
            {
                int selectedDepartmentRow = df.selectedDepartmentRow;
                ta.ПереместитьОтделение(df.getSelectedDepartmentID(), moveDepartmentTownTextBox.Text);
                MessageBox.Show("Отделение перемещено в город " + moveDepartmentTownTextBox.Text);
                df.updateDepartmentsGrid();
                df.setPreviousDepartmentSelection(selectedDepartmentRow);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Отделение не было перемещено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
