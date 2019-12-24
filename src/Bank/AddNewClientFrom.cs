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
    public partial class AddNewClientFrom : Form
    {
        public OperatorForm of;

        public AddNewClientFrom(OperatorForm of)
        {
            InitializeComponent();
            this.of = of;
        }

        private void addNewClientButton_Click(object sender, EventArgs e)
        {
            if (newClientNameTextBox.Text == "")
            {
                MessageBox.Show("Введите ФИО клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newClientTownTextBox.Text == "")
            {
                MessageBox.Show("Введите город клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newClientIncomeTextBox.Text == "")
            {
                MessageBox.Show("Введите доход клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double income;
            bool isNum = double.TryParse(newClientIncomeTextBox.Text, out income);
            if (!isNum)
            {
                MessageBox.Show("Доход клиента должен быть числом",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                newClientIncomeTextBox.Clear();
                return;
            }
            QueriesTableAdapter ta = new QueriesTableAdapter();
            try
            {
                ta.ДобавитьКлиента(newClientNameTextBox.Text, newClientTownTextBox.Text, decimal.Parse(newClientIncomeTextBox.Text));
                MessageBox.Show("Клиент добавлен");
                of.updateClientsGrid();
                of.updatePotentialClientsGrid();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Клиент не был добавлен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
