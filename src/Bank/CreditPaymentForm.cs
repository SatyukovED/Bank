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
    public partial class CreditPaymentForm : Form
    {
        private ClientFullInfoForm cfif;
        private QueriesTableAdapter ta = new QueriesTableAdapter();

        public CreditPaymentForm(ClientFullInfoForm cfif)
        {
            InitializeComponent();
            this.cfif = cfif;
            creditNumberTextBox.Text = cfif.getSelectedCredit().ToString();
            decimal? restOfCreditSum = 0;
            ta.ПосчитатьОстатокПоКредиту(cfif.getSelectedCredit(), ref restOfCreditSum);
            restOfCreditSumTextBox.Text = restOfCreditSum.ToString();
        }

        private void fillUpTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fillUpTypeComboBox.Text == "Наличные")
            {
                accountNumberComboBox.Visible = false;
                accountNumberLabel.Visible = false;
                noAccountTextBox.Visible = false;
            }
            else if (fillUpTypeComboBox.Text == "Карта")
            {
                accountNumberComboBox.Visible = true;
                accountNumberLabel.Visible = true;
                BankDataSet.СписокАктивныхКартКлиентаDataTable dt = new BankDataSet.СписокАктивныхКартКлиентаDataTable();
                списокАктивныхКартКлиентаTableAdapter.Fill(dt, cfif.clientID);
                accountNumberComboBox.DataSource = dt;
                accountNumberComboBox.DisplayMember = "НомерКарты";
                if (dt.Rows.Count == 0)
                {
                    accountNumberComboBox.Visible = false;
                    accountNumberLabel.Visible = false;
                    noAccountTextBox.Visible = true;
                    noAccountTextBox.Text = "Карт нет";
                }
                else
                {
                    accountNumberComboBox.Visible = true;
                    accountNumberLabel.Visible = true;
                    noAccountTextBox.Visible = false;
                }
            }
            else
            {
                accountNumberComboBox.Visible = true;
                accountNumberLabel.Visible = true;
                BankDataSet.СписокАктивныхВкладовКлиентаDataTable dt = new BankDataSet.СписокАктивныхВкладовКлиентаDataTable();
                списокАктивныхВкладовКлиентаTableAdapter.Fill(dt, cfif.clientID);
                accountNumberComboBox.DataSource = dt;
                accountNumberComboBox.DisplayMember = "НомерВклада";
                if (dt.Rows.Count == 0)
                {
                    accountNumberComboBox.Visible = false;
                    accountNumberLabel.Visible = false;
                    noAccountTextBox.Visible = true;
                    noAccountTextBox.Text = "Вкладов нет";
                }
                else
                {
                    accountNumberComboBox.Visible = true;
                    accountNumberLabel.Visible = true;
                    noAccountTextBox.Visible = false;
                }
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            double sumToPay;
            bool isNum = double.TryParse(sumToPayTextBox.Text, out sumToPay);
            if (!isNum)
            {
                MessageBox.Show("Сумма должна быть числом",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sumToPayTextBox.Clear();
                return;
            }
            if (fillUpTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите способ оплаты", "Способ оплаты не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (fillUpTypeComboBox.Text == "Наличные")
            {
                ta.ОсуществитьОперацию(4, null, 3, cfif.getSelectedCredit(),
                                        decimal.Parse(sumToPayTextBox.Text), cfif.of.operatorID);
                MessageBox.Show("Перевод осуществлен");
                cfif.updateClientCreditOperations();
                cfif.updateClientCredits();
                cfif.updateClientStatus();
                cfif.of.updateClientsGrid();
                this.Close();
            }
            else if (fillUpTypeComboBox.Text == "Карта")
            {
                if (noAccountTextBox.Visible == true)
                {
                    MessageBox.Show("Выберите другой способ оплаты", "Нет карт для оплаты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (accountNumberComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите карту", "Карта не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool? availabilityToTransfer = false;
                ta.ПроверитьВозможностьПереводаСКарты(int.Parse(accountNumberComboBox.Text), 
                    decimal.Parse(sumToPayTextBox.Text), ref availabilityToTransfer);
                if (availabilityToTransfer == true)
                {
                    ta.ОсуществитьОперацию(1, int.Parse(accountNumberComboBox.Text), 3, cfif.getSelectedCredit(),
                       decimal.Parse(sumToPayTextBox.Text), cfif.of.operatorID);
                    ta.СнятьСКарты(int.Parse(accountNumberComboBox.Text), decimal.Parse(sumToPayTextBox.Text));
                    MessageBox.Show("Перевод осуществлен");
                    cfif.updateClientCreditOperations();
                    cfif.updateClientCredits();
                    cfif.updateClientStatus();
                    cfif.of.updateClientsGrid();
                    cfif.updateClientCards();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на карте", "Перевод не осуществлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (noAccountTextBox.Visible == true)
                {
                    MessageBox.Show("Выберите другой способ оплаты", "Нет вкладов для оплаты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (accountNumberComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите вклад", "Вклад не выбран", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool? availabilityToTransfer = false;
                ta.ПроверитьВозможностьПереводаСВклада(int.Parse(accountNumberComboBox.Text), 
                    decimal.Parse(sumToPayTextBox.Text), ref availabilityToTransfer);
                if (availabilityToTransfer == true)
                {
                    ta.ОсуществитьОперацию(2, int.Parse(accountNumberComboBox.Text), 3, cfif.getSelectedCredit(),
                                           decimal.Parse(sumToPayTextBox.Text), cfif.of.operatorID);
                    ta.СнятьСВклада(int.Parse(accountNumberComboBox.Text), decimal.Parse(sumToPayTextBox.Text));
                    MessageBox.Show("Перевод осуществлен");
                    cfif.updateClientCreditOperations();
                    cfif.updateClientCredits();
                    cfif.updateClientStatus();
                    cfif.of.updateClientsGrid();
                    cfif.updateClientContributions();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на вкладе", "Перевод не осуществлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
