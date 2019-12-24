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
    public partial class AddNewCreditRequestForm : Form
    {
        private OperatorForm of;
        private ClientFullInfoForm cfif;
        private int? duration;
        private int id;

        public AddNewCreditRequestForm(OperatorForm of, int ID)
        {
            InitializeComponent();
            this.of = of;
            this.cfif = null;
            this.id = ID;
        }

        public AddNewCreditRequestForm(OperatorForm of, ClientFullInfoForm cfif, int ID)
        {
            InitializeComponent();
            this.of = of;
            this.cfif = cfif;
            this.id = ID;
        }

        private void newRequestSumComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newRequestSumComboBox.SelectedItem.ToString() == "100000")
            {
                newRequestPercentTextBox.Text = "10,00";
            }
            else if (newRequestSumComboBox.SelectedItem.ToString() == "250000")
            {
                newRequestPercentTextBox.Text = "12,50";
            }
            else if (newRequestSumComboBox.SelectedItem.ToString() == "500000")
            {
                newRequestPercentTextBox.Text = "15,00";
            }
            else
            {
                newRequestPercentTextBox.Text = "20,00";
            }
        }

        private void addNewCreditRequestButton_Click(object sender, EventArgs e)
        {
            if (newRequestDurationComboBox.SelectedItem == null)
            {
                MessageBox.Show("Не выбран срок кредита", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (newRequestDurationComboBox.SelectedItem.ToString() == "1 год")
            {
                duration = 12;
            }
            else if (newRequestDurationComboBox.SelectedItem.ToString() == "2,5 года")
            {
                duration = 30;
            }
            else if (newRequestDurationComboBox.SelectedItem.ToString() == "5 лет")
            {
                duration = 60;
            }
            else
            {
                duration = 120;
            }
            QueriesTableAdapter ta = new QueriesTableAdapter();
            try
            {
                decimal percent = decimal.Parse(newRequestPercentTextBox.Text);
                bool? status = false;
                ta.УзнатьСтатусКлиента(id, ref status);
                if (status == true)
                {
                    percent /= 2;
                }
                ta.ПодатьЗаявкуНаКредит(id, decimal.Parse(newRequestSumComboBox.Text), percent, duration, of.operatorID);
                MessageBox.Show("Заявка на кредит отправлена");
                if (status == true)
                {
                    MessageBox.Show("Процент в заявке на кредит уменьшен вдвое,\nтак как статус клиента - Премиум");
                }
                of.updatePotentialClientsGrid();
                if (cfif != null)
                {
                    cfif.updateClientCreditRequests();
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Заявка на кредит не была отправлена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
