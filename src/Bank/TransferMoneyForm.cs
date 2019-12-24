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
    public partial class TransferMoneyForm : Form
    {
        private ClientFullInfoForm cfif;
        private int isCard;
        private QueriesTableAdapter ta = new QueriesTableAdapter();

        public TransferMoneyForm(ClientFullInfoForm cfif, int isCard)
        {
            InitializeComponent();
            this.cfif = cfif;
            this.isCard = isCard;
            if (isCard == 1)
            {
                accountNumberLabel.Text = "Номер карты";
                accountNumberTextBox.Text = cfif.getSelectedCard().ToString();
            }
            else
            {
                accountNumberLabel.Text = "Номер вклада";
                accountNumberTextBox.Text = cfif.getSelectedContribution().ToString();
            }
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            double transferSum;
            bool isNum = double.TryParse(transferSumTextBox.Text, out transferSum);
            if (!isNum)
            {
                MessageBox.Show("Сумма должна быть числом",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                transferSumTextBox.Clear();
                return;
            }
            int receiverAccountNumber;
            isNum = int.TryParse(receiverAccountNumberTextBox.Text, out receiverAccountNumber);
            if (!isNum)
            {
                MessageBox.Show("Номер счета получателя должен быть числом",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                receiverAccountNumberTextBox.Clear();
                return;
            }
            int? receiverAccountType = 0;
            ta.УзнатьТипАктивногоСчета(int.Parse(receiverAccountNumberTextBox.Text), ref receiverAccountType);
            if (receiverAccountType == 0)
            {
                MessageBox.Show("Не существует активной карты или вклада с таким номером",
                        "Ошибка перевода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                receiverAccountNumberTextBox.Clear();
                return;
            }
            if (isCard == 1)
            {
                bool? availabilityToTransfer = false;
                ta.ПроверитьВозможностьПереводаСКарты(cfif.getSelectedCard(), 
                    decimal.Parse(transferSumTextBox.Text), ref availabilityToTransfer);
                if (availabilityToTransfer == true)
                {
                    ta.ОсуществитьОперацию(1, cfif.getSelectedCard(), receiverAccountType, 
                        int.Parse(receiverAccountNumberTextBox.Text),
                        decimal.Parse(transferSumTextBox.Text), cfif.of.operatorID);
                    if (receiverAccountType == 1)
                    {
                        ta.НачислитьНаКарту(int.Parse(receiverAccountNumberTextBox.Text), 
                            decimal.Parse(transferSumTextBox.Text));
                    }
                    else
                    {
                        ta.НачислитьНаВклад(int.Parse(receiverAccountNumberTextBox.Text), 
                            decimal.Parse(transferSumTextBox.Text));
                    }
                    ta.СнятьСКарты(cfif.getSelectedCard(), decimal.Parse(transferSumTextBox.Text));
                    MessageBox.Show("Перевод осуществлен");
                    cfif.updateClientCards();
                    cfif.updateClientCardOperations();
                    cfif.updateClientContributions();
                    cfif.updateClientStatus();
                    cfif.of.updateClientsGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на карте", "Перевод не осуществлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool? availabilityToTransfer = false;
                ta.ПроверитьВозможностьПереводаСВклада(cfif.getSelectedContribution(), 
                    decimal.Parse(transferSumTextBox.Text), ref availabilityToTransfer);
                if (availabilityToTransfer == true)
                {
                    ta.ОсуществитьОперацию(2, cfif.getSelectedContribution(), 
                        receiverAccountType, int.Parse(receiverAccountNumberTextBox.Text),
                        decimal.Parse(transferSumTextBox.Text), cfif.of.operatorID);
                    if (receiverAccountNumber == 1)
                    {
                        ta.НачислитьНаКарту(int.Parse(receiverAccountNumberTextBox.Text), 
                            decimal.Parse(transferSumTextBox.Text));
                    }
                    else
                    {
                        ta.НачислитьНаВклад(int.Parse(receiverAccountNumberTextBox.Text), 
                            decimal.Parse(transferSumTextBox.Text));
                    }
                    ta.СнятьСВклада(cfif.getSelectedContribution(), decimal.Parse(transferSumTextBox.Text));
                    MessageBox.Show("Перевод осуществлен");
                    cfif.updateClientCards();
                    cfif.updateClientContributionOperations();
                    cfif.updateClientContributions();
                    cfif.updateClientStatus();
                    cfif.of.updateClientsGrid();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Недостаточно средств на карте", "Перевод не осуществлен", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
